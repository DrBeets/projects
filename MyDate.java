package main.java;

import java.util.Calendar;
import java.util.GregorianCalendar;

/* MyDate class assignment 10.14 Created by Tristan Rogers 04/22 */

public class MyDate{
    int year;
    int month;
    int day;

    // no arg constructor for current date
    public MyDate(){
        GregorianCalendar cal = new GregorianCalendar();
        year = cal.get(GregorianCalendar.YEAR);
        month = cal.get(GregorianCalendar.MONTH);
        day = cal.get(GregorianCalendar.DAY_OF_MONTH);
    }

    // constructor for specified y/m/d
    public MyDate(int year, int month, int day){
        this.year = year;
        this.month = month;
        this.day = day;
    }

    // constructor for elapsed time in ms
    public MyDate(long elapsedTime){
        GregorianCalendar elapsed = new GregorianCalendar(1970, 1, 1);
        GregorianCalendar cal = new GregorianCalendar();

        cal.setTimeInMillis(elapsed.getTimeInMillis() + elapsedTime);

        year = cal.get(GregorianCalendar.YEAR);
        month = cal.get(GregorianCalendar.MONTH);
        day = cal.get(GregorianCalendar.DAY_OF_MONTH);
    }

    // getters for y/m/d 

    public int getYear(){
        return year;
    }

    public int getMonth(){
        return month;
    }

    public int getDay(){
        return day;
    }

    // set date method
    public void setDate(long elapsedTime){
        GregorianCalendar cal = new GregorianCalendar();
        cal.setTimeInMillis(elapsedTime);

        year = cal.get(GregorianCalendar.YEAR);
        month = cal.get(GregorianCalendar.MONTH);
        day = cal.get(GregorianCalendar.DAY_OF_MONTH);
    }

    // Display Date as a string
    @Override
   public String toString() {
       return "Day= " + day + ", Month= " + month + ", Year= " + year;

   }

    // main test method
    public static void main(String[] args) {
        MyDate test1 = new MyDate();
        System.out.println("Current date:" + test1);

        MyDate test2 = new MyDate(34355555133101L);
        System.out.println("34355555133101L since midnight 01/01/1970:" + test2);

        MyDate test3 = new MyDate(561555550000L);
        System.out.println("561555550000L ms:" + test3);
    }
}