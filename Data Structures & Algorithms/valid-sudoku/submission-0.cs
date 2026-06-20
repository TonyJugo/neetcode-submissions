public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int length = 9;
        //valid duplicate in row & column
        for(int i = 0; i < length; i++){
            HashSet<char> setRow = new HashSet<char>();
            HashSet<char> setColumn = new HashSet<char>();
            int rowCount = 0 ;
            int columnCount = 0;
            for(int j = 0; j < length; j++){
                if(board[i][j] != '.'){
                rowCount++;    
                setRow.Add(board[i][j]);
                }
                if(board[j][i] != '.'){
                columnCount++;
                setColumn.Add(board[j][i]);
                }
            }
            if(setRow.Count != rowCount || setColumn.Count != columnCount){
                return false;
            }
        }
        // valid 3x3 sudoku
        for(int block = 0; block < length; block++){
            HashSet<char> seen = new HashSet<char>();
            for(int j = 0; j < 3; j++){
                int rowIndex = (block / 3) * 3 + j;
                for(int k = 0; k < 3; k++){
                    int columnIndex = (block % 3) * 3 + k;
                    //duyệt row
                    if(board[rowIndex][columnIndex] != '.'){
                        if(!seen.Add(board[rowIndex][columnIndex])){
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }
}
