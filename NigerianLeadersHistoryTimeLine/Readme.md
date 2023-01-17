# *NigerianLeadersHistoryTimeLine*
This is a simple library that returns a list of past and present Nigerian presidents.


### **Built With**
-Languages: C#
-Frameworks: .NET 6.0
-Technologies: GitHub and Visual Studio

### ***To get started***
The package can be installed by any of these two ways:

**install using .NET CLI:**
- run: dotnet add package NigerianLeadersHistoryTimeLine --version 1.0.0

**install using Visual Studio**
- Right-click on your project dependencies
- Select manage Nuget packages
- Search for NigerianLeadersHistoryTimeLine
- Select install

### **Prerequisites**
Understanding how NuGet Packages work


### **Usage**
You could display past and present Nigerian presidents based on a certain criteria like name, age, number of tenures, or even if the president is dead or alive.
This package ships with two methods, viz:

*The DisplayAllPresidents() method:*
which has no parameters and returns a list of all past and present Nigerian presidents

*The DisplayPresidentsBy(string? name = null, int? age = null, int? tenures = null, bool? isAlive = null) method:*
whose parameters could either be a name, an age, number of tenures, or living status. These parameters are what are used to filter the results. 

These are static methods, so this is how youw ould want to use it:

### **Code Samples**

...

using static NigerianLeadersHistoryTimeLine.Utility;

internal class Program
{
    static void Main(string[] args)
    {
         //displays all presidents whose age equals 85, and ruled only for a tenure
         DisplayPresidentsBy(age: 85, tenures: 1);

         //displays all dead presidents
         DisplayPresidentsBy(isAlive: false);

         //displays all presidents who are alive
         DisplayPresidentsBy(isAlive: true);
         
         //displays all presidents who have ruled for three tenures
         DisplayPresidentsBy(tenures: 3);

         //displays all the presidents
         DisplayAllPresidents();
    }
}
...