using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;


//------------------
//Creator: aeonhack
//Site: elitevs.net
//Created: 9/23/2011
//Changed: 9/23/2011
//Version: 1.0.0
//Theme Base: 1.5.2
//------------------
class FutureTheme : ThemeContainer152
{

    public FutureTheme()
    {
        MoveHeight = 24;
        BackColor = Color.FromArgb(34, 34, 34);

        SetColor("Back", 34, 34, 34);
        SetColor("Gradient1", 34, 34, 34);
        SetColor("Gradient2", 23, 23, 23);
        SetColor("Border1", 34, 34, 34);
        SetColor("Border2", 49, 49, 49);
        SetColor("Border3", Color.Black);
        SetColor("Line1", Color.Black);
        SetColor("Line2", Color.Black);
        SetColor("Hatch1", Color.Black);
        SetColor("Hatch2", 34, 34, 34);
        SetColor("Shade1", 70, Color.Black);
        SetColor("Shade2", Color.Transparent);
        SetColor("Text", Color.White);
    }

    private Color C1;
    private Color C2;
    private Color C3;
    private Color C4;
    private Color C5;
    private Pen P1;
    private Pen P2;
    private Pen P3;
    private Pen P4;
    private Pen P5;
    private HatchBrush B1;

    private SolidBrush B2;
    protected override void ColorHook()
    {
        C1 = GetColor("Back");
        C2 = GetColor("Gradient1");
        C3 = GetColor("Gradient2");
        C4 = GetColor("Shade1");
        C5 = GetColor("Shade2");

        P1 = new Pen(GetColor("Border1"));
        P2 = new Pen(GetColor("Line1"));
        P3 = new Pen(GetColor("Line2"));
        P4 = new Pen(GetColor("Border2"));
        P5 = new Pen(GetColor("Border3"));

        B1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, GetColor("Hatch1"), GetColor("Hatch2"));
        B2 = new SolidBrush(GetColor("Text"));

        BackColor = C1;
    }


    private Rectangle RT1;
    protected override void PaintHook()
    {
        G.Clear(C1);

        RT1 = new Rectangle(1, 1, Width - 2, 22);
        DrawGradient(C2, C3, RT1, 90f);
        DrawBorders(P1, RT1);

        G.DrawLine(P2, 0, 23, Width, 23);

        G.FillRectangle(B1, 0, 24, Width, 13);

        DrawGradient(C4, C5, 0, 24, Width, 6);

        G.DrawLine(P3, 0, 37, Width, 37);
        DrawBorders(P4, 1, 38, Width - 2, Height - 39);

        DrawText(B2, HorizontalAlignment.Left, 5, 0);

        DrawBorders(P5);
    }

}

//------------------
//Creator: aeonhack
//Site: elitevs.net
//Created: 9/23/2011
//Changed: 9/23/2011
//Version: 1.0.0
//Theme Base: 1.5.2
//------------------
class FutureButton : ThemeControl152
{


    private ColorBlend Blend;
    public FutureButton()
    {
        SetColor("Blend1", 28, 28, 28);
        SetColor("Blend2", 32, 32, 32);
        SetColor("Blend3", 24, 24, 24);
        SetColor("Border1A", 40, 40, 40);
        SetColor("Border1B", 48, 48, 48);
        SetColor("Border2", Color.Black);
        SetColor("Border3", 24, 24, 24);
        SetColor("Line1", 44, 44, 44);
        SetColor("TextShade", Color.Black);
        SetColor("Text", Color.White);
        SetColor("Corners", 40, 40, 40);

        Blend = new ColorBlend();
        Blend.Positions = new float[] {
            0f,
            0.5f,
            1f
        };
    }

    private Pen P1;
    private Pen P2;
    private Pen P3;
    private Pen P4;
    private SolidBrush B1;
    private SolidBrush B2;
    private Color C1;
    private Color C2;

    private Color C3;
    protected override void ColorHook()
    {
        C1 = GetColor("Border1A");
        C2 = GetColor("Border1B");
        C3 = GetColor("Corners");

        P2 = new Pen(GetColor("Border2"));
        P3 = new Pen(GetColor("Border3"));
        P4 = new Pen(GetColor("Line1"));

        B1 = new SolidBrush(GetColor("TextShade"));
        B2 = new SolidBrush(GetColor("Text"));

        Blend.Colors = new Color[] {
            GetColor("Blend1"),
            GetColor("Blend2"),
            GetColor("Blend3")
        };
    }


    private LinearGradientBrush GB1;
    protected override void PaintHook()
    {
        DrawGradient(Blend, ClientRectangle, 90f);

        GB1 = new LinearGradientBrush(ClientRectangle, C1, C2, 90f);
        P1 = new Pen(GB1);

        DrawBorders(P1);
        DrawBorders(P2, 1);

        if (State == MouseState.Down)
        {
            DrawBorders(P3, 2);

            DrawText(B1, HorizontalAlignment.Center, 2, 2);
            DrawText(B2, HorizontalAlignment.Center, 1, 1);
        }
        else
        {
            G.DrawLine(P4, 2, 2, Width - 3, 2);

            DrawText(B1, HorizontalAlignment.Center, 1, 1);
            DrawText(B2, HorizontalAlignment.Center, 0, 0);
        }

        DrawCorners(C3, 1, 1, Width - 2, Height - 2);
        DrawCorners(BackColor);
    }
}