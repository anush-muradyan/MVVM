using System;

namespace Commands {
    public interface ICommand<T> {
    		bool CanExecute();
    		void Execute(T data);
    
    		void Subscribe(Action<T> callback);
    	}
}