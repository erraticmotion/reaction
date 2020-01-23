namespace System
{
    using Extensions;

    using Threading;

    using Microsoft.SPOT;
    using Microsoft.SPOT.Presentation;
    using Microsoft.SPOT.Presentation.Controls;
    using Microsoft.SPOT.Presentation.Media;

    /// <summary>
    /// 
    /// </summary>
    public class Console
    {
        private static Application application;
        private static ConsoleWindow consoleWindow;
        private static readonly Thread ConsoleThread;

        /// <summary>
        /// 
        /// </summary>
        static Console()
        {
            ConsoleThread = new Thread(ConsoleThreadProcedure);
            ConsoleThread.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        private static void ConsoleThreadProcedure()
        {
            consoleWindow = new ConsoleWindow();
            application = new Application();
            application.Run(consoleWindow);
        }

        /// <summary>
        /// Writes string to the console window
        /// </summary>
        /// <param name="text"></param>
        public static void WriteLine(string text)
        {
            //Make sure statics are set
            while (consoleWindow == null)
            {
                Thread.Sleep(50);
            }

            lock (consoleWindow)
            {
                consoleWindow.WriteLine(text);
            }
        }

        public static void WriteLine(object item)
        {
            WriteLine(item.ToString());
        }

        #region ConsoleWindow class

        private class ConsoleWindow : Window
        {
            private readonly ScrollViewer scrollViewer;
            private readonly TextFlow textFlow;
            private readonly Color textColor;
            private readonly Color backgroundColor;

            private readonly int numOfLines;

            /// <summary>
            /// Initializes a new instance of the <see cref="ConsoleWindow"/> class.
            /// </summary>
            internal ConsoleWindow() : this(Color.White, Color.Black)
            {
            }

            /// <summary>
            /// Initialize console window with the given text and background colours
            /// </summary>
            /// <param name="textColor">text colour</param>
            /// <param name="backgroundColor">background colour</param>
            private ConsoleWindow(Color textColor, Color backgroundColor)
            {
                this.textColor = textColor;
                this.backgroundColor = backgroundColor;
                Font = Resource.GetFont(Resource.FontResources.Small);
                Background = new SolidColorBrush(this.backgroundColor);

                scrollViewer = new ScrollViewer
                    {
                        LineHeight = Font.Height,
                        ScrollingStyle = ScrollingStyle.LineByLine,
                        Width = SystemMetrics.ScreenWidth,
                        Height = SystemMetrics.ScreenHeight
                    };

                numOfLines = scrollViewer.Height / scrollViewer.LineHeight;

                textFlow = new TextFlow
                    { 
                        VerticalAlignment = VerticalAlignment.Top, 
                        HorizontalAlignment = HorizontalAlignment.Left 
                    };

                scrollViewer.Child = textFlow;
                Child = scrollViewer;
            }

            /// <summary>
            /// Adds the string to the text flow, followed by the EndOfLine text run
            /// </summary>
            /// <param name="textLine">string to add</param>
            /// <returns>
            /// null (to match DispatcherOperationCallback signature)
            /// </returns>
            internal object WriteLine(object textLine)
            {
                if (!Dispatcher.CheckAccess())
                {
                    Dispatcher.BeginInvoke(WriteLine, textLine);
                }
                else
                {
                    var textString = textLine as string;
                    if (textString.IsNullOrEmpty())
                    {
                        textString = " ";
                    }

                    if (textFlow.TextRuns.Count / 2 >= numOfLines)
                    {
                        textFlow.TextRuns.RemoveAt(0);
                        textFlow.TextRuns.RemoveAt(0);
                    }

                    textFlow.TextRuns.Add(textString, Font, textColor);
                    textFlow.TextRuns.Add(TextRun.EndOfLine);
                }

                return null;
            }
        }

        #endregion
    }
}