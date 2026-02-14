using Godot;
using System;
using System.Collections.Generic;

public partial class SceneSwitcher : Node
{
    public enum Layer
    {
        Scene,
        UI
    }

    Node sceneRoot;
    Node uiRoot;

    Dictionary<Layer, Stack<Node>> stack = new();
    Dictionary<string, Node> cache = new();

    public override void _Ready()
    {
        sceneRoot = GetNode<Node>("../Scene");
        uiRoot = GetNode<Node>("../Scene/Overlay");

        stack[Layer.Scene] = new Stack<Node>();
        stack[Layer.UI] = new Stack<Node>();
    }

    public Node Push(string scenePath, Layer layer, bool cacheScene = true)
    {
        return null;
    }
    public Node Pop() { return null; }
}
