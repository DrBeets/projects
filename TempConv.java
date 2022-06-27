// A stand-alone GUI Java program that displays a Fahrenheit to Celsius
// temperate conversion table.

// Written by Tristan Rogers, Tampa, FL USA, 2020


import java.awt.*;
import java.awt.event.*;

public class TempConv extends Frame
{
   // Creating the GUI
   public TempConv ()
   {
      setTitle( "Fahrenheit to Celsius Chart" );
      setSize(200,500);
      setVisible( true );

      addWindowListener(
         new WindowAdapter()
         {  public void windowClosing( WindowEvent e )
            {  System.exit( 0 );
            }
         }
      );
   }

   public static void main ( String [] args )
   {
      TempConv me = new TempConv();
   }

   public void paint ( Graphics g )
   {
      // Declaring temperature variables
      int posx=80,posy=50;
      int fahrenheit=0,celsius=1;
      double temperature;
      
      // Drawing the table
      setBackground(Color.CYAN);
      g.drawString("F", 50, 50);
      g.drawString("C", 150, 50);
      
      //Loop to increase the Fahrenheit temperature by ten, and show the 
      //corresponding Celsius temperature.
      for(int i=0;i<=250;i+=10){
          
      //assigining i to the fahrenheit value for calculation
      fahrenheit=i;
      temperature=fahrenheit-32;
      temperature=temperature*(5.0/9);
      celsius=(int) Math.round(temperature);
      
      //Set color of temperature based on freezing or boiling
      if (fahrenheit <= 30 && celsius <= 0)
        g.setColor(Color.BLUE);
      else if (fahrenheit > 210 && celsius > 99)
        g.setColor(Color.RED);
        else g.setColor(Color.BLACK);
      
      g.drawString(fahrenheit+"", 50, posx);
      g.drawString(celsius+"", 150, posx);
      
      //Increas the value of posx for the next line to print under first line.
      posx=posx+15;
                                }
    }                                     
}