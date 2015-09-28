namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo Spreadsheet for ASP.NET MVC.
    /// </summary>
    public class SpreadsheetBuilder: WidgetBuilderBase<Spreadsheet, SpreadsheetBuilder>
    {
        private readonly Spreadsheet container;
        /// <summary>
        /// Initializes a new instance of the <see cref="Spreadsheet"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public SpreadsheetBuilder(Spreadsheet component)
            : base(component)
        {
            container = component;
        }

        //>> Fields
        
        /// <summary>
        /// The name of the currently active sheet.
        /// </summary>
        /// <param name="value">The value that configures the activesheet.</param>
        public SpreadsheetBuilder ActiveSheet(string value)
        {
            container.ActiveSheet = value;

            return this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value that configures the columnwidth.</param>
        public SpreadsheetBuilder ColumnWidth(double value)
        {
            container.ColumnWidth = value;

            return this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value that configures the columns.</param>
        public SpreadsheetBuilder Columns(double value)
        {
            container.Columns = value;

            return this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value that configures the headerheight.</param>
        public SpreadsheetBuilder HeaderHeight(double value)
        {
            container.HeaderHeight = value;

            return this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value that configures the headerwidth.</param>
        public SpreadsheetBuilder HeaderWidth(double value)
        {
            container.HeaderWidth = value;

            return this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value that configures the rowheight.</param>
        public SpreadsheetBuilder RowHeight(double value)
        {
            container.RowHeight = value;

            return this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value that configures the rows.</param>
        public SpreadsheetBuilder Rows(double value)
        {
            container.Rows = value;

            return this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configurator">The action that configures the sheets.</param>
        public SpreadsheetBuilder Sheets(Action<SpreadsheetSheetFactory> configurator)
        {
            configurator(new SpreadsheetSheetFactory(container.Sheets));
            return this;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value that configures the toolbar.</param>
        public SpreadsheetBuilder Toolbar(bool value)
        {
            container.Toolbar = value;

            return this;
        }
        
        //<< Fields


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Spreadsheet()
        ///             .Name("Spreadsheet")
        ///             .Events(events => events
        ///                 .Render("onRender")
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public SpreadsheetBuilder Events(Action<SpreadsheetEventBuilder> configurator)
        {

            configurator(new SpreadsheetEventBuilder(Component.Events));

            return this;
        }
        
    }
}

