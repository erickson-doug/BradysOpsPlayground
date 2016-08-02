using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ConsoleApp
{
    /// <summary>
    /// Provides an ontological system for the application domain.
    /// </summary>
    public class AppModel
    {
        /// <summary>
        /// A basic property just being used to show the basic functionality. 
        /// </summary>
        public string BasicProperty { get; set; }

        /// <summary>
        /// Does some unit of work.
        /// </summary>
        /// <param name="options">Options for this method call</param>
        public void DoSomething(DoSomethingParameters options)
        {
        }
    }

    /// <summary>
    /// Parameters object used by the AppModel.DoSomething() event.
    /// <seealso cref="AppModel.DoSomething"/>
    /// </summary>
    public class DoSomethingParameters
    {
        /// <summary>
        /// The ID of this method request.
        /// </summary>
        public int Id { get; set; }
    }
}
