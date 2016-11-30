﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Entities
{
    public enum INTERACTIVE_EVENT
    {
        ONLOAD,
        TOUCH,
        DRAG,
        DROP,
        EXPLORER_BUTTON_CLICK,
        MOVE_CAMERA_END,
        TOUCH_ON_NOTHING
    }
    public enum INTERACTIVE_ACTION
    {
        SCALE,
        ANIMATION,
        MOVE,
        CHANGE_SCENE,
        SHOW_TEXT,
        HIDE_DISPLAY_TEXT_UI,
        MOVE_CAMERA,
        NONE
    }
    [Serializable]
    public class Interactive
    {
        public bool isDefaultAnimation = true;
        public bool isScaling=false;
        public string eventName;
        public Action[] actions;

    }
}


