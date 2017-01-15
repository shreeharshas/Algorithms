public class NimGame {
    public boolean canWinNim(int n) {
    	if(n<=3)
    		return true;
    	return !canWinNim(n-3)||!canWinNim(n-2)||!canWinNim(n-1);
    }
}