namespace Task2._9;

public interface ICommand
{
    Task ExecuteAsync(object parameter);
}