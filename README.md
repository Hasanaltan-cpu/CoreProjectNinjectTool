In this passage,i will try to explain what the Inversion Of Control and Dependency Inversion Principle.In addition to that, how we implement these to project.
First of all Principle and Patterns are different terms.Principle (as Robert Martin's SOLİD Principles) provide well-thought,tested and successfulled explanation in terms of Problem.On the other hand,Patterns are totally distinct from principle.Patterns are use for the principle they are not the explanation.
Robert Martin (Bob Uncle) says in the last principle of the SOLİD , tightly coupled classes will be hazardous effect for the projects in terms of expenses ,besides that,he points out that if the developers want to build a extendable,changeable and testable projects they need to use losely coupled classes.Why? As the Robert Martin mentioned;there are numerous disadvantages of tightly coupled classes.

1-Tightly coupled classes can not be clear as much as Losely coupled classes.For instance,new developer who joined ur team , developer should be trouble when the read and understand and manage these structure.

2-Tightly coupled classes are hard to mutable.Mutable means changeable.Actually,it can be change but for just one adding process ,these codes should be written from zero.It is totally expensive for the developers.On the other hand when u have Losely coupled classes u can give a new  behaviour to your classes by using interfaces.To change a property of any class,interface class which is losely coupled with your child class,can be touched easily.

3-Losely Coupled classes gives more oppurtunity to write clear readable and understandable codes.
<h5><p>What is the different between IoC Container and Dependency Injection ? </p><h5>

Dependency Injection is the pattern for DIP.

IoC Container is the Framework for IoC.


<h3>Inversion Of Control<h3>

![Inversion Of Control](https://gblobscdn.gitbook.com/assets%2F-MRFT_yi0rNDZjdshVPA%2F-MRFTdj019qItY-Y2__g%2F-MRFaAjBSyfkg3EerVv9%2Fioc-steps.png?alt=media&token=a989ef18-d894-41a0-b6ba-e27947056c5d)


IoC is  inverting the control.You can imagine that  you drive a car to your work.As the result of this scene u control your car directly.The IoC principle suggests to invert to control.That's why you hire a cab, when another person will drive your car to work.
Let's understand this on the example;



     public class A
    {
       B b;
      public A()
       {
        b=new B();
     }
       public void Task1()
      {
       b.someMethod();
      }
    }

      public class B
      {
           public void SomeMethod()
      {
      }
      }



As u can see in the above example,class A calls b.SomeMethod() to complete its Task1.It means Class A is Dependent on Class B.On the other hand;


    public class A
    {
    B b;
    public A()
    {
        b=Factory.GetObjectOfB();
    }
    
    public void Task1()
    {
        b.SomeMethod();
    }
    }
    public class Factory
    {    
    public static B  GetObjectOfB()
    {
    return new B();
    }
    }


In this basic example we can understand, how the control can be invert.

![Inversion Of Control Patterns](https://gblobscdn.gitbook.com/assets%2F-MRFT_yi0rNDZjdshVPA%2F-MRFTdj019qItY-Y2__g%2F-MRFevCnBjoIK2u8W6B8%2Fioc-patterns.png?alt=media&token=ea4fbc3f-16ca-4611-8f73-14c200d4accf)


In the above example; i gave the Factory Patterns for the Inversion of Control Principle.

