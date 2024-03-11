public class Solution {
    public bool JudgeCircle(string moves) {
        int move = 0;

        for(int i = 0; i < moves.Length; i++)
        {
            if(moves[i] == 'U')
            {
                move += 10;
            }
            if(moves[i] == 'D')
            {
                move -= 10;
            }
            if(moves[i] == 'L')
            {
                move += 1;
            }
            if(moves[i] == 'R')
            {
                move -= 1;
            }
        }
        return move == 0 ? true : false;
    }
}
