package main.java;

import java.util.Date;
import java.util.List;
import java.util.ArrayList;
import java.lang.System;
import java.util.*;

/* Account class assignment 9.7 Created by Tristan Rogers 04/22 */

public class Account {
    private int id = 0;
    private double balance = 0.0;
    private double annualInterestRate = 0.0;
    private Date dateCreated;
    private String customer;
    private static List<Transaction> transactionsList = null;

    public List<Transaction> getTransactionsList() {
        if (transactionsList == null) {
            transactionsList = new ArrayList<Transaction>();
            return transactionsList;
        }
        return transactionsList;
    }
    public Account(){
        dateCreated = new Date();
    }
    

    public Account(int id, double balance, String customer){
        this();
        this.id = id;
        this.balance = balance;
        this.customer = customer;
    }
    @Override
    public String toString() {
        return "Account [id=" + id + ", balance=" + balance
                + ", annualInterestRate=" + annualInterestRate
                + ", customerName=" + customer + "]";
    }

    public int getId(){
        return this.id;
    }

    public double getBalance(){
        return this.balance;
    }

    public void setId(int id){
        this.id = id;
    }

    public void setBalance(double balance){
        this.balance = balance;
    }

    public double getAnnualInterestRate(){
        return annualInterestRate;
    }

    public void setAnnualInterestRate(double annualInterestRate){
        this.annualInterestRate = annualInterestRate;
    }

    public String getDateCreated(){
        return this.dateCreated.toString();
    }

    public double getMonthlyInterestRate(){
        return (annualInterestRate / 100) / 12;
    }

    public double getMonthlyInterest(){
        return balance * getMonthlyInterestRate();
    }

    public double withdraw(double amount){
       double transactionAmount = balance;
       this.setBalance(this.getBalance() - balance);

       Date transactiondate = new Date();
       char transactionType = 'w';
       double remainingbalance = this.getBalance();
       String description = "I withdraw the money $" + transactionAmount;
       Transaction transaction = new Transaction(transactiondate,
               transactionType, transactionAmount, remainingbalance,
               description);

       List<Transaction> list = getTransactionsList();
       list.add(transaction);
       return this.getBalance();
    }

    public double deposit(double amount){
        double transactionAmount = balance;
       this.setBalance(this.getBalance() + balance);
       Date transactiondate = new Date();
       char transactionType = 'd';
       double remainingbalance = this.getBalance();
       String description = "i deposited the money with $" + transactionAmount;
       Transaction transaction = new Transaction(transactiondate,
               transactionType, transactionAmount, remainingbalance,
               description);

       List<Transaction> list = getTransactionsList();
       list.add(transaction);

       return this.getBalance();
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("enter the customer name");
        String customerName = scanner.next();
        Random random = new Random();
        int id = random.nextInt(1000);
        System.out.println("enter the balance in your account");
        double balance = scanner.nextDouble();
        System.out.println("enter the annualinterest rate");
        double annualInterestRate = scanner.nextDouble();
 
        Account account = new Account(id, balance, customerName);
        account.setAnnualInterestRate(annualInterestRate);
 
        System.out.println("enter the money to deposit");
        double depositedAmount = scanner.nextDouble();
        double amount = account.deposit(depositedAmount);
 
        System.out.println("enter the money withdraw");
 
        double withdrawAmount = scanner.nextDouble();
 
        double amount1 = account.withdraw(withdrawAmount);
 
        System.out.println("the account information is");
 
        System.out.println(account.toString());
 
        System.out.println("the all transacions are");
 
        for (Transaction transaction : account.getTransactionsList()) {
            System.out.println(transaction.toString());
    }
}
}


