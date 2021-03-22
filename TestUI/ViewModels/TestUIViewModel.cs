#region

using Agilent.OpenLab.Framework.UI.Module;

using Microsoft.Practices.Unity;

namespace Agilent.OpenLab.TestUI
{
    #endregion

    /// <summary>
    /// TestUIViewModel
    /// </summary>
    /// <remarks>
    /// </remarks>
    public partial class TestUIViewModel : BaseViewModel, ITestUIViewModel
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TestUIViewModel"/> class.
        /// </summary>
        /// <param name="container">
        /// The container. 
        /// </param>
        /// <remarks>
        /// </remarks>
        public TestUIViewModel(IUnityContainer container)
            : base(container)
        {
            this.View = this.UnityContainer.Resolve<ITestUIView>();
            this.View.Model = this;
            this.SubscribeEvents();
            this.InitializeCommands();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the view.
        /// </summary>
        /// <value>
        /// The view. 
        /// </value>
        /// <remarks>
        /// </remarks>
        public ITestUIView View { get; set; }

        #endregion
    }
}