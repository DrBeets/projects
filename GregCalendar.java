package main.java;

import java.util.Calendar;
import java.util.GregorianCalendar;

/* GregCalendar class assignment 9.5 Created by Tristan Rogers 04/22 */

public class GregCalendar{
    public static void main(String[] args) {
        GregorianCalendar calendar = new GregorianCalendar();

        System.out.println("Current Year, Month, and Day:");
        System.out.print(calendar.get(Calendar.YEAR) + "/");
        System.out.print(calendar.get(Calendar.MONTH) + "/");
        System.out.print(calendar.get(Calendar.DAY_OF_MONTH));

        calendar.setTimeInMillis(1234567898765L);

        System.out.println("\nTime elapsed since January 1, 1970 new date is:");
        System.out.print(calendar.get(Calendar.YEAR) + "/");
        System.out.print(calendar.get(Calendar.MONTH) + "/");
        System.out.print(calendar.get(Calendar.DAY_OF_MONTH));
    }
}