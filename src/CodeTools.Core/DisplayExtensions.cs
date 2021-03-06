using System.Collections.Generic;
using System.Text;
using CodeTools.Core.Projects;

namespace CodeTools.Core
{
    internal static class DisplayExtensions
    {
        public static string Display(this Solution[] solutions, StringBuilder output = null)
        {
            if (output == null) output = new StringBuilder();
            foreach (Solution solution in solutions)
            {
                output.AppendLine("--------------------------------------------------------------------------");
                Display(solution, output);
            }
            return output.ToString();
        }

        public static string Display(this Solution solution, StringBuilder output = null)
        {
            if (output == null) output = new StringBuilder();
            if (solution == null)
            {
                output.Append("<null>");
            }
            else
            {
                output.AppendLine(solution.Name);
                if (solution.CSharpProjects != null)
                {
                    foreach (KeyValuePair<string, CSharpProject> projectItem in solution.CSharpProjects)
                    {
                        output.Append("+ " + projectItem.Key + ": ");
                        Display(projectItem.Value, output);
                    }
                }
            }
            return output.ToString();
        }

        public static string Display(this CSharpProject project, StringBuilder output)
        {
            if (output == null) output = new StringBuilder();
            if (project == null)
            {
                output.Append("<null>");
            }
            else
            {
                output.AppendLine("> " + project.Path);
                //foreach (Reference reference in project.References)
                //{
                //    Display(reference, output);
                //}
            }
            return output.ToString();
        }

        public static string Display(this Reference reference, StringBuilder output)
        {
            if (output == null) output = new StringBuilder();
            if (reference == null)
            {
                output.Append("<null>");
            }
            else
            {
                output.AppendLine("## " + reference.Name);
            }
            return output.ToString();
        }
    }
}