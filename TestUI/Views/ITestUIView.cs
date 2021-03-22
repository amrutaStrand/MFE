
namespace Agilent.OpenLab.TestUI
{
    /// <summary>
    /// ITestUIView
    /// </summary>
    public interface ITestUIView
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model. 
        /// </value>
        ITestUIViewModel Model { get; set; }

        #endregion
    }
}