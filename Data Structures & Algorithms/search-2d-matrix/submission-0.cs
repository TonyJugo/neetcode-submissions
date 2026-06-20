public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int col = matrix[0].Length;
        for(int i = 0; i < matrix.Length; i++){
            for(int j = 0; j < col; j++){
                if(matrix[i][j] == target) return true;
            }
        }
        return false;
    }
}
