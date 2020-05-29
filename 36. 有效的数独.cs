public class Solution
{
    public bool IsValidSudoku(char[][] board) 
    {
        int[,] row = new int[9, 9];
        int[,] col = new int[9, 9];
        int[,] box = new int[9, 9];

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j <9; j++)
            {
                if (board[i][j] == '.') continue;
                int curNum = board[i][j] - '1';
                if (row[i, curNum] > 0) return false;
                row[i, curNum]++;
                if (col[j, curNum] > 0) return false;
                col[j, curNum]++;
                if (box[j/3+(i/3)*3, curNum] > 0) return false;
                box[j/3+(i/3)*3, curNum]++;
            }
        }
        return true;
    }
}