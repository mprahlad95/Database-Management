/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Kashish Grover
 */

import java.io.*;
import java.util.Scanner;

public class StudentMain {
    
    static int ch;
    static Scanner in=new Scanner(System.in);
        
    public static void main(String[] ar)
    {
        
        do{  
                System.out.println("  ******Student Menu*****  ");
                System.out.println("1) Enter new record........");
                System.out.println("2) View existing records...");
                System.out.println("3) Search for record......."); //delete and modify record
                System.out.println("0) Exit....................");
            
                System.out.print("Enter choice - ");
                ch=in.nextInt();
                
                switch(ch)
                {
          case 1:
              //Serialization
                        Student object;
                        object = new Student();
                        object.getData();
                    try{
                        File f1;
                        f1 = new File("student.txt");
                        
                        FileOutputStream fos;
                        fos = new FileOutputStream(f1,true);
                        
                        ObjectOutputStream oos;
                        oos = new ObjectOutputStream(fos);
                        
                        oos.writeObject(object);
                        oos.close();
                    }catch(IOException e) {
                        System.out.println("Exception during serialization: " + e);
                        }
                        break;
                        
          case 2:
              //Deserialization
              
              try {
                        
                        Student obj[];
                        int i=0;
                        FileInputStream fis;
                        fis = new FileInputStream("student.txt");
                        ObjectInputStream ois;
                        ois = new ObjectInputStream(fis);
                        
                        while((obj=(Student)ois.readObject())!=null)
                        {
                            System.out.println(obj);
                            i++;
                        }
                        
                        ois.close();
                    }
                        catch(IOException | ClassNotFoundException e) {
                        System.out.println("Exception during deserialization: " + e);
                        
                          }
          
              
              break;
          
          case 3:
                                      
                }
            
        }while(ch!=0);
    }
    
}
