using System.Collections.Generic;

namespace ImageCA.Maths
{
    /// <summary>
    /// Master class to manage all math inputs
    /// </summary>
    public class MathMaster
    {
        private List<string> equations;

        /// <summary>
        /// Appens an equation to the equations list
        /// </summary>
        /// <param name="equation">the equation to add</param>
        public void AppendEquation(string equation) => equations.Add(equation);
        
        /// <summary>
        /// compute the lists of equations
        /// </summary>
        public void Compute()
        {
            
        }
    }
}
