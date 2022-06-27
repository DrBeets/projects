package main.java;

import java.util.*;
/* Course class assignment 10.9 Created by Tristan Rogers 04/22 */
public class Course {
    private String courseName;
    // create an array list to keep the size dynamic
    private ArrayList<String> students = new ArrayList<String>();
    private int numberOfStudents;

    public Course(String courseName) {
        this.courseName = courseName;
        this.numberOfStudents = 0;
    }

    public void addStudent(String student) {
        numberOfStudents++;
        students.add(student);

    }

    public ArrayList<String> getStudents() {
        return students;
    }

    public int getNumberOfStudents() {
        return numberOfStudents;
    }

    public String getCourseName() {
        return courseName;
    }

    // drop student method, using ignore case
    public void dropStudent(String student) {
        for (int i = 0; i < students.size(); i++) {
            if (student.equalsIgnoreCase(students.get(i))) {
                students.remove(i);
            }
        }
    }
    // clear method to remove all students from the array
    public void clear() {
        students.clear();
    }

    // test main method
    public static void main(String[] args) {
        String name;
        Scanner input = new Scanner(System.in);
        Course c = new Course("Gaming");
        c.addStudent("Tristan");
        c.addStudent("Jonah");
        c.addStudent("Ash");

        ArrayList<String> students = c.getStudents();
        System.out.println("List of Students: ");
        for (int i = 0; i < students.size(); i++) {
            System.out.println(students.get(i));
        }
        // Prompt user which student to drop
        System.out.println("\nEnter the name of student to drop: ");
        name = input.next();
        c.dropStudent(name);

        System.out.println("\nList of Students After Removal:");
        for (int i = 0; i < students.size(); i++) {
            System.out.println(students.get(i));
        }
    }
}


