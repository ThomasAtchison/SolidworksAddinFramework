using ReactiveUI;
using SolidworksAddinFramework;

namespace DemoMacroFeatures.ManipulatorSample
{
    public class ManipulatorSampleModel : ReactiveObject
    {
        private SelectionData _Body = SelectionData.Empty;

        public SelectionData Body
        {
            get { return _Body; }
            set { this.RaiseAndSetIfChanged(ref _Body, value); }
        }
    }
}