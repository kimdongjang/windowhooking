﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Client.Hooking
{
    public enum enumKeys
    {
        Modifiers = -65536,
        None = 0,
        LButton = 1,
        RButton = 2,
        Cancel = 3,
        MButton = 4,
        XButton1 = 5,
        XButton2 = 6,
        Back = 8,
        Tab = 9,
        LineFeed = 10,
        Clear = 12,
        Enter = 13,
        Return = 13,
        ShiftKey = 16,
        ControlKey = 17,
        Menu = 18,
        Pause = 19,
        CapsLock = 20,
        Capital = 20,
        KanaMode = 21,
        HanguelMode = 21,
        HangulMode = 21,
        JunjaMode = 23,
        FinalMode = 24,
        KanjiMode = 25,
        HanjaMode = 25,
        Escape = 27,
        IMEConvert = 28,
        IMENonconvert = 29,
        IMEAceept = 30,
        IMEAccept = 30,
        IMEModeChange = 31,
        Space = 32,
        Prior = 33,
        PageUp = 33,
        Next = 34,
        PageDown = 34,
        End = 35,
        Home = 36,
        Left = 37,
        Up = 38,
        Right = 39,
        Down = 40,
        Select = 41,
        Print = 42,
        Execute = 43,
        PrintScreen = 44,
        Snapshot = 44,
        Insert = 45,
        Delete = 46,
        Help = 47,
        D0 = 48,
        D1 = 49,
        D2 = 50,
        D3 = 51,
        D4 = 52,
        D5 = 53,
        D6 = 54,
        D7 = 55,
        D8 = 56,
        D9 = 57,
        A = 65,
        B = 66,
        C = 67,
        D = 68,
        E = 69,
        F = 70,
        G = 71,
        H = 72,
        I = 73,
        J = 74,
        K = 75,
        L = 76,
        M = 77,
        N = 78,
        O = 79,
        P = 80,
        Q = 81,
        R = 82,
        S = 83,
        T = 84,
        U = 85,
        V = 86,
        W = 87,
        X = 88,
        Y = 89,
        Z = 90,
        LWin = 91,
        RWin = 92,
        Apps = 93,
        Sleep = 95,
        NumPad0 = 96,
        NumPad1 = 97,
        NumPad2 = 98,
        NumPad3 = 99,
        NumPad4 = 100,
        NumPad5 = 101,
        NumPad6 = 102,
        NumPad7 = 103,
        NumPad8 = 104,
        NumPad9 = 105,
        Multiply = 106,
        Add = 107,
        Separator = 108,
        Subtract = 109,
        Decimal = 110,
        Divide = 111,
        F1 = 112,
        F2 = 113,
        F3 = 114,
        F4 = 115,
        F5 = 116,
        F6 = 117,
        F7 = 118,
        F8 = 119,
        F9 = 120,
        F10 = 121,
        F11 = 122,
        F12 = 123,
        F13 = 124,
        F14 = 125,
        F15 = 126,
        F16 = 127,
        F17 = 128,
        F18 = 129,
        F19 = 130,
        F20 = 131,
        F21 = 132,
        F22 = 133,
        F23 = 134,
        F24 = 135,
        NumLock = 144,
        Scroll = 145,
        LShiftKey = 160,
        RShiftKey = 161,
        LControlKey = 162,
        RControlKey = 163,
        LMenu = 164,
        RMenu = 165,
        BrowserBack = 166,
        BrowserForward = 167,
        BrowserRefresh = 168,
        BrowserStop = 169,
        BrowserSearch = 170,
        BrowserFavorites = 171,
        BrowserHome = 172,
        VolumeMute = 173,
        VolumeDown = 174,
        VolumeUp = 175,
        MediaNextTrack = 176,
        MediaPreviousTrack = 177,
        MediaStop = 178,
        MediaPlayPause = 179,
        LaunchMail = 180,
        SelectMedia = 181,
        LaunchApplication1 = 182,
        LaunchApplication2 = 183,
        Oem1 = 186,
        OemSemicolon = 186,
        Oemplus = 187,
        Oemcomma = 188,
        OemMinus = 189,
        OemPeriod = 190,
        OemQuestion = 191,
        Oem2 = 191,
        Oemtilde = 192,
        Oem3 = 192,
        Oem4 = 219,
        OemOpenBrackets = 219,
        OemPipe = 220,
        Oem5 = 220,
        Oem6 = 221,
        OemCloseBrackets = 221,
        Oem7 = 222,
        OemQuotes = 222,
        Oem8 = 223,
        Oem102 = 226,
        OemBackslash = 226,
        ProcessKey = 229,
        Packet = 231,
        Attn = 246,
        Crsel = 247,
        Exsel = 248,
        EraseEof = 249,
        Play = 250,
        Zoom = 251,
        NoName = 252,
        Pa1 = 253,
        OemClear = 254,
        a = 255,
        b = 256,
        c = 257,
        d = 258,
        e = 259,
        f = 260,
        g = 261,
        h = 262,
        i = 263,
        j = 264,
        k = 265,
        l = 266,
        m = 267,
        n = 268,
        o = 269,
        p = 270,
        q = 271,
        r = 272,
        s = 273,
        t = 274,
        u = 275,
        v = 276,
        w = 277,
        x = 278,
        y = 279,
        z = 280,
        ㅁ = 281,
        ㅠ = 282,
        ㅊ = 283,
        ㅇ = 284,
        ㄷ = 285,
        ㄹ = 286,
        ㅎ = 287,
        ㅗ = 288,
        ㅑ = 289,
        ㅓ = 290,
        ㅏ = 291,
        ㅣ = 292,
        ㅡ = 293,
        ㅜ = 294,
        ㅐ = 295,
        ㅔ = 296,
        ㅂ = 297,
        ㄱ = 298,
        ㄴ = 299,
        ㅅ = 230,
        ㅕ = 231,
        ㅍ = 232,
        ㅈ = 233,
        ㅌ = 234,
        ㅛ = 235,
        ㅋ = 236,
        KeyCode = 65535,
        Shift = 65536,
        Control = 131072,
        Alt = 262144,
    }
}

