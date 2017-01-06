/*
Solution to find the perimeter of an island. Problem given at https://leetcode.com/submissions/detail/88070798/
*/
public class islandPerimeter {
    //method to check if the given cell is is the border or not
    boolean checkIsland(String neighbour, int i, int j, int maxRow, int maxColumn){
        switch(neighbour){
            case "left": 
                if(j==0) return false;
                else return true;
            case "right": 
                if(j==maxColumn-1) return false;
                else return true;
            case "top": 
                if(i==0) return false;
                else return true;
            case "bottom": 
                if(i==maxRow-1) return false;
                else return true;
        }
        return false;
    }
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
                    perimeter = (checkIsland("left", i, j, maxRow, maxColumn))?(grid[i][j-1]==0?perimeter+1:perimeter):perimeter+1;
                    perimeter = (checkIsland("right", i, j, maxRow, maxColumn))?(grid[i][j+1]==0?perimeter+1:perimeter):perimeter+1;
                    perimeter = (checkIsland("top", i, j, maxRow, maxColumn))?(grid[i-1][j]==0?perimeter+1:perimeter):perimeter+1;
                    perimeter = (checkIsland("bottom", i, j, maxRow, maxColumn))?(grid[i+1][j]==0?perimeter+1:perimeter):perimeter+1;
                }
            }
        }
        return perimeter;
    }
}
