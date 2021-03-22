#region

using System.Windows;

namespace Agilent.OpenLab.TestUI
{
    #endregion

    /// <summary>
    /// Interaction logic for TestUIView.xaml
    /// </summary>
    /// <remarks>
    /// </remarks>
    public partial class TestUIView : ITestUIView
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TestUIView"/> class.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TestUIView()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model. 
        /// </value>
        /// <remarks>
        /// </remarks>
        public ITestUIViewModel Model
        {
            get
            {
                return this.DataContext as ITestUIViewModel;
            }

            set
            {
                this.DataContext = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Called when [loaded].
        /// </summary>
        /// <param name="sender">
        /// The sender. 
        /// </param>
        /// <param name="e">
        /// The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data. 
        /// </param>
        /// <remarks>
        /// </remarks>
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// Called when [unload].
        /// </summary>
        /// <param name="sender">
        /// The sender. 
        /// </param>
        /// <param name="e">
        /// The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data. 
        /// </param>
        /// <remarks>
        /// </remarks>
        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
        }

        #endregion
    }
}