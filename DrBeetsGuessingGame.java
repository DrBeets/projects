
import java.util.*; 
import javax.swing.*; 

public class DrBeetsGuessingGame{ 
    
static JFrame f = new JFrame(); //created an object for JFrame class
static boolean playGame(int number){
String message = "";

//For loop with i representing the guesses remaining
for(int i=4; i > 0 ; i--){
    
    int guess = Integer.parseInt(JOptionPane.showInputDialog(f,"("+i+" Guesses left) "+message+" What is your guess? (1-10)"));

    int compare = compareTo(number, guess);

    if(compare > 0)
        message = "Too high!";

    else if(compare < 0)
        message = "Too low!";

    else if(compare == 0)
            return true;
}
return false;
}

static int compareTo(int number, int guess){
    return guess-number;
}
public static void main(String[] args) {
    int a;
    Random rand = new Random();
    
    //do while loop to restart game until yes is NOT selected at the end
    do{
        
        //Random number generator (1-10)
        int number = rand.nextInt(10)+1; 
        
        //Calls playGame method with the newly generated random number
        boolean result = playGame(number); 
        
        //Answer confirmation
        if(result)
            a = JOptionPane.showConfirmDialog(f,"(Game Over) Nicely done and thanks for playing! Play again? ");
        //If answer was wrong, and user ran out of guesses
        else a = JOptionPane.showConfirmDialog(f,"(Game Over) You'll get 'em next time champ. ( The number was "+number+") Play again? ");
        
        // Closes the game if user does not pick yes
        if(a != JOptionPane.YES_OPTION) 
        System.exit(0);
        
    }while(a == JOptionPane.YES_OPTION);
  }
}