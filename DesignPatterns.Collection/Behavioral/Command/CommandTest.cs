using DesignPatterns.Behavioral.Command.Invoker;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class CommandTest
    {
        public static void Execute()
        {
            // Create user and let it compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }
    }
}
