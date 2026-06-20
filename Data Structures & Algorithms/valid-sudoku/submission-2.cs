public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // 1. brute force
        // int length = 9;
        // //valid duplicate in row & column
        // for(int i = 0; i < length; i++){
        //     HashSet<char> setRow = new HashSet<char>();
        //     HashSet<char> setColumn = new HashSet<char>();
        //     int rowCount = 0 ;
        //     int columnCount = 0;
        //     for(int j = 0; j < length; j++){
        //         if(board[i][j] != '.'){
        //         rowCount++;    
        //         setRow.Add(board[i][j]);
        //         }
        //         if(board[j][i] != '.'){
        //         columnCount++;
        //         setColumn.Add(board[j][i]);
        //         }
        //     }
        //     if(setRow.Count != rowCount || setColumn.Count != columnCount){
        //         return false;
        //     }
        // }
        // //valid 3x3 duplicate
        // for(int block = 0; block < length; i++){
        //     HashSet<char> set = new HashSet<char>();
        //     for(int i = 0; i < 3; i++){
        //         for(int k = 0; k < 3; k++){
        //             int row = block / 3
        //         }
        //     }
        // }
        // return true;
        //2. hash map - one pass O(n^2)
        // Dictionary<int, HashSet<char>> rowSet = new Dictionary<int, HashSet<char>>();
        // Dictionary<int, HashSet<char>> columnSet = new Dictionary<int, HashSet<char>>();
        // Dictionary<string, HashSet<char>> blockSet = new Dictionary<string, HashSet<char>>();
        // for(int r = 0; r < 9; r++){
        //     for(int c = 0; c < 9; c++){
        //         if(board[r][c] == '.') continue;
        //         string blockKey = $"{r/3},{c/3}";
        //         //check trước lúc add xem có duplicate ko
        //         if((rowSet.ContainsKey(r) && rowSet[r].Contains(board[r][c])) 
        //         || (columnSet.ContainsKey(c) && columnSet[c].Contains(board[r][c])) 
        //         || (blockSet.ContainsKey(blockKey) && blockSet[blockKey].Contains(board[r][c]))){
        //             return false;
        //         }
        //         //nếu key đó chưa có
        //         if(!rowSet.ContainsKey(r)) rowSet[r] = new HashSet<char>();
        //         if(!columnSet.ContainsKey(c)) columnSet[c] = new HashSet<char>();
        //         if(!blockSet.ContainsKey(blockKey)) blockSet[blockKey] = new HashSet<char>();
        //         // add board[r][c]
        //         rowSet[r].Add(board[r][c]);
        //         columnSet[c].Add(board[r][c]);
        //         blockSet[blockKey].Add(board[r][c]);
        //     }
        // }
        // return true;
        //3. bit mask

        int[] rowBit = new int[9];
        int[] columnBit = new int[9];
        int[] blockBit = new int[9];
        for(int r = 0; r < 9; r++){
            for(int c = 0; c < 9; c++){
                if(board[r][c] == '.') continue;
                //convert 0-9 char thành value
                int val = board[r][c] - '1';
                //convert tọa độ thành block index
                int blockIndex = (r/3)*3 + (c/3);
                //check trước add sau, tắt bit , nếu có bit (>0) trả false
                if((rowBit[r] & (1<<val)) > 0 
                || (columnBit[c] & (1<<val)) > 0 
                || (blockBit[blockIndex] & (1<<val)) > 0){
                    return false;
                }
                //dịch bit  sang trái val lần và bật bit thêm vào mảng store
                rowBit[r] |= (1<<val);
                columnBit[c] |= (1<<val);
                blockBit[blockIndex] |= (1<<val);

            }
        }
        return true;
    }
}
