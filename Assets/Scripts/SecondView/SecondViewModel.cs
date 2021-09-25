using Commands;
using Controls;
using View;

namespace SecondView {
    public class SecondViewModel : IViewModel<SecondModel> {
        public SecondModel Model { get; set; }

        public ICommand<string> UpdateContentCommand { get; }

        public SecondViewModel() {
            UpdateContentCommand = new StringCommand();
        }

        public void Init() {
            UpdateContentCommand.Subscribe(data => Model.ContentText = data);
        }
    }
}