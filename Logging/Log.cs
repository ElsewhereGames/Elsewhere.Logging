
#region Using

#endregion Using

namespace Elsewhere.Logging
{

    public class Log
    {

        #region Life-Cycle
        
        /// <summary>
        /// Creates a new instance of a log with the specified name. The log level
        /// will default to <see cref="Level.Warning"/>.
        /// </summary>
        /// <param name="name">Identifies this log. Is not required to be 
        /// unique.</param>
        public Log(string name) : this(name, Level.Warning)
        {
            
        }

        /// <summary>
        /// Creates a new instance of a log with the specified name and threshold.
        /// </summary>
        /// <param name="name">Identifies this log. Is not required to be 
        /// unique.</param>
        /// <param name="threshold">Messages at this level or above are sent on
        /// to the outputs of this log.</param>
        public Log(string name, Level threshold)
        {
            this.name = name;
            this.threshold = threshold;
        }

        #endregion Life-Cycle
        
        #region Properties

        #region Name

        private string name;

        /// <summary>
        /// Gets a name to identify this log with. This name does not have to be
        /// unique when compared to other logs.
        /// </summary>
        public string Name
        {
            get { return this.name; }
        }

        #endregion Name

        #region Treshold

        private Level threshold;

        /// <summary>
        /// Gets the level at or above which messages are sent to the outputs of 
        /// this log.
        /// </summary>
        public Level Threshold
        {
            get { return this.threshold; }
        }

        #endregion Treshold

        #endregion Properties

    }

}
