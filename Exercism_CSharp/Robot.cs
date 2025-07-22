namespace Exercism_CSharp
{
    #region Task Description
    /*
    Manage robot factory settings.
    When a robot comes off the factory floor, it has no name.
    The first time you turn on a robot, a random name is generated in the format of two uppercase letters followed by three digits, such as RX837 or BC811.
    Every once in a while we need to reset a robot to its factory settings, which means that its name gets wiped. The next time you ask, that robot will respond with a new random name.
    The names must be random: they should not follow a predictable sequence. Using random names means a risk of collisions. Your solution must ensure that every existing robot has a unique name.
    */
    #endregion

    public class Robot
    {
        #region Properties

        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public static List<string> ExistingRobotNames = new();
        #endregion

        #region Init
        public Robot()
        {
            _name = TurnOn();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Resets the Robot's name, removes it from the list of registered Robot names, and assigns a new name.
        /// </summary>
        public void Reset()
        {
            ExistingRobotNames.Remove(_name);
            _name = TurnOn();
        }

        /// <summary>
        /// Recursively assigns and registers a new name to Robot.
        /// </summary>
        /// <returns>A string indicating Robot's new name.</returns>
        public string TurnOn()
        {
            Random rand = new();

            // random uppercase letters using uppercase ASCII range
            int ascii1 = rand.Next(65, 91);
            char c1 = (char)ascii1;
            int ascii2 = rand.Next(65, 91);
            char c2 = (char)ascii2;

            // random numbers
            int num1 = rand.Next(0, 10);
            int num2 = rand.Next(0, 10);
            int num3 = rand.Next(0, 10);

            // store in string
            string[] arr = [c1.ToString(), c2.ToString(), num1.ToString(), num2.ToString(), num3.ToString()];
            string robotName = string.Concat(arr);

            if (!ExistingRobotNames.Contains(robotName))
            {
                ExistingRobotNames.Add(robotName);
                return robotName;
            }

            return TurnOn();
        }
        #endregion
    }
}
