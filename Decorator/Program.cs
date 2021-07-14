using System;

namespace EmployeeDecoratorPatternDemo
{
    public abstract class EmployeeComponent
    {
        public abstract string getName();

        public abstract void doTask();

        public abstract void join(DateTime joinDate);

        public abstract void terminate(DateTime terminateDate);

        public void showBasicInformation()
        {
            Console.WriteLine("-------");
            Console.WriteLine("The basic information of " + getName());

            join(DateTime.Now);
            terminate(DateTime.Now.AddMonths(6));
        }
    }

    class EmployeeConcreteComponent : EmployeeComponent
    {
        private string name;

        public EmployeeConcreteComponent(string name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return name;
        }

        public override void join(DateTime joinDate)
        {
            Console.WriteLine(this.getName() + " joined on " + joinDate.ToLongDateString());
        }
        public override void terminate(DateTime terminateDate)
        {
            Console.WriteLine(this.getName() + " terminated on " + terminateDate.ToLongDateString());
        }

        public override void doTask()
        {
            // Unassigned task
        }
    }

    public abstract class EmployeeDecorator : EmployeeComponent
    {
        protected EmployeeComponent employee;

        protected EmployeeDecorator(EmployeeComponent employee)
        {
            this.employee = employee;
        }

        public override string getName()
        {
            return employee.getName();
        }

        public override void join(DateTime joinDate)
        {
            employee.join(joinDate);
        }

        public override void terminate(DateTime terminateDate)
        {
            employee.terminate(terminateDate);
        }
    }

    public class Manager : EmployeeDecorator
    {
        public Manager(EmployeeComponent employee) : base(employee)
        {

        }

        public void createRequirement()
        {
            Console.WriteLine(this.employee.getName() + " is create requirements.");
        }

        public void assignTask()
        {
            Console.WriteLine(this.employee.getName() + " is assigning tasks.");
        }

        public void manageProgress()
        {
            Console.WriteLine(this.employee.getName() + " is managing the progress.");
        }

        public override void doTask()
        {
            employee.doTask();
            createRequirement();
            assignTask();
            manageProgress();
        }
    }

    public class TeamLeader : EmployeeDecorator
    {
        public TeamLeader(EmployeeComponent employee) : base(employee)
        {

        }

        public void planing()
        {
            Console.WriteLine(this.employee.getName() + " is planing.");
        }

        public void motivate()
        {
            Console.WriteLine(this.employee.getName() + " is motivating his members.");
        }

        public void monitor()
        {
            Console.WriteLine(this.employee.getName() + " is monitoring his members.");
        }

        public override void doTask()
        {
            employee.doTask();
            planing();
            motivate();
            monitor();
        }
    }

    public class TeamMember : EmployeeDecorator
    {
        public TeamMember(EmployeeComponent employee) : base(employee)
        {

        }

        public void reportTask()
        {
            Console.WriteLine(this.employee.getName() + " is reporting.");
        }

        public void coordinateWithOthers()
        {
            Console.WriteLine(this.employee.getName() + " is coordinating with other members of his team.");
        }

        public override void doTask()
        {
            employee.doTask();
            reportTask();
            coordinateWithOthers();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NORMAL EMPLOYEE: ");
            EmployeeComponent employee = new EmployeeConcreteComponent("BinhDepTrai");
            employee.showBasicInformation();
            employee.doTask();

            Console.WriteLine("\nTEAM LEADER: ");
            EmployeeComponent teamLeader = new TeamLeader(employee);
            teamLeader.showBasicInformation();
            teamLeader.doTask();

            Console.WriteLine("\nMANAGER: ");
            EmployeeComponent manager = new Manager(employee);
            manager.showBasicInformation();
            manager.doTask();

            Console.WriteLine("\nTEAM LEADER AND MANAGER: ");
            EmployeeComponent teamLeaderAndManager = new Manager(teamLeader);
            teamLeaderAndManager.showBasicInformation();
            teamLeaderAndManager.doTask();
        }
    }
}
