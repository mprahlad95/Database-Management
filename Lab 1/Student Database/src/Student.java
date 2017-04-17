/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Kashish Grover
 */

import java.io.Serializable;
import java.util.Scanner;

public class Student implements Serializable{
    
    int reg;
    String name;
    int marks;
    static Scanner sc;
    
    
    
    void getData()
    {
        sc=new Scanner(System.in);
        System.out.print("Enter name - ");
            name=sc.nextLine();
        System.out.print("Enter Registration number - ");
            reg=sc.nextInt();
        System.out.print("Enter Marks - ");
            marks=sc.nextInt();
    }
    
    @Override
    public String toString() {
                     return name+"\t"+reg+"\t"+marks;
                    }
}
