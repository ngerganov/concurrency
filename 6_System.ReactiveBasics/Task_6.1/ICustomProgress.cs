namespace Task_6._1;

public interface ICustomProgress<T>
{
    event EventHandler<T> ProgressChanged;
}