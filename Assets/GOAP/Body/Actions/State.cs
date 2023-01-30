public abstract class State {
    protected Agent Context;
    public bool IsDone;

    protected State(Agent context) {
        Context = context;
    }

    public abstract void Do();
    public abstract void Transition();
}