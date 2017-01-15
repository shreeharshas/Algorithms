/*
Solution to find the perimeter of an island. Problem given at https://leetcode.com/submissions/detail/88070798/
*/
public class islandPerimeter {
    public int islandPerimeter(int[][] grid) {
        int perimeter = 0;
        int maxRow = grid.length;
        int maxColumn = grid[0].length;
        for(int i=0;i<maxRow;i++){
            for(int j=0;j<maxColumn;j++){
                if(grid[i][j]==1){
                    //check left right top and bottom
                    //if they are 1, increment counter
                    //handled edge case
                    perimeter = (j!=0)?(grid[i][j-1]==0?perimeter+1:perimeter):perimeter+1;
                    perimeter = (j!=maxColumn-1)?(grid[i][j+1]==0?perimeter+1:perimeter):perimeter+1;
                    perimeter = (i!=0)?(grid[i-1][j]==0?perimeter+1:perimeter):perimeter+1;
                    perimeter = (i!=maxRow -1)?(grid[i+1][j]==0?perimeter+1:perimeter):perimeter+1;
                }
            }
        }
        return perimeter;
    }
}
