class DragaoGold : Monstro
{
    public DragaoGold() : base("Dragão", 500, 25, 15, 400, 400) { }

    public override Monstro EncontrarMonstro()
    {
        return new DragaoGold();
    }
}
