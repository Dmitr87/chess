using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ChessPiece
{
    public override List<Vector2Int> GetAvailableMoves(ref ChessPiece[,] board, int numberOfTilesX, int numberOfTilesY)
    {
        List<Vector2Int> r = new List<Vector2Int>(); // �������� ������ � ����� ���������� - ����� ������ �� ��� x � y ��������������
        //����� ��� ����� ���������� ����� 
        //������ �����
        for (int x = currentX + 1, y = currentY + 1; x < numberOfTilesX && y < numberOfTilesY; x++, y++)
        {
            if (board[x, y] == null) //���� ��� ����� �� ������ ������
                r.Add(new Vector2Int(x, y)); //��������� ��������� ���
            else
            {
                if (board[x, y].team != team) //���� ������ �� ������ ���������
                    r.Add(new Vector2Int(x, y)); //��������� ���

                break; //�� ���������� ��������� ������ �.�. ������ ������ �� ������, ������� ����� ������
            }
        }
        //����� �����
        for (int x = currentX - 1, y = currentY + 1; x >= 0 && y < numberOfTilesY; x--, y++)
        {
            if (board[x, y] == null)
                r.Add(new Vector2Int(x, y));
            else
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
        }
        //������ ����
        for (int x = currentX + 1, y = currentY - 1; x < numberOfTilesX && y >= 0; x++, y--)
        {
            if (board[x, y] == null)
                r.Add(new Vector2Int(x, y));
            else
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
        }
        //����� ����
        for (int x = currentX - 1, y = currentY - 1; x >= 0 && y >= 0; x--, y--)
        {
            if (board[x, y] == null)
                r.Add(new Vector2Int(x, y));
            else
            {
                if (board[x, y].team != team)
                    r.Add(new Vector2Int(x, y));

                break;
            }
        }

        return r; //���������� ��� ��������� ����
    }
}
