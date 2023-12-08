namespace Tasks
{
    internal interface InterfaceTask
    {
        string NameTask { get; }
        string Date { get; }

        void StartProgram();
    }
}
