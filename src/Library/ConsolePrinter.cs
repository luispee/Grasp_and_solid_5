using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IPrintableRecipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}