﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DK = Aurora.Devices.DeviceKeys;

namespace Aurora.Devices.OpenRGB
{
    public static class OpenRGBKeyNames
    {
        public static readonly Dictionary<string, DK> Keyboard = new Dictionary<string, DK>()
        {
            { "Key: A"                , DK.A                 },
            { "Key: B"                , DK.B                 },
            { "Key: C"                , DK.C                 },
            { "Key: D"                , DK.D                 },
            { "Key: E"                , DK.E                 },
            { "Key: F"                , DK.F                 },
            { "Key: G"                , DK.G                 },
            { "Key: H"                , DK.H                 },
            { "Key: I"                , DK.I                 },
            { "Key: J"                , DK.J                 },
            { "Key: K"                , DK.K                 },
            { "Key: L"                , DK.L                 },
            { "Key: M"                , DK.M                 },
            { "Key: N"                , DK.N                 },
            { "Key: O"                , DK.O                 },
            { "Key: P"                , DK.P                 },
            { "Key: Q"                , DK.Q                 },
            { "Key: R"                , DK.R                 },
            { "Key: S"                , DK.S                 },
            { "Key: T"                , DK.T                 },
            { "Key: U"                , DK.U                 },
            { "Key: V"                , DK.V                 },
            { "Key: W"                , DK.W                 },
            { "Key: X"                , DK.X                 },
            { "Key: Y"                , DK.Y                 },
            { "Key: Z"                , DK.Z                 },
            { "Key: 1"                , DK.ONE               },
            { "Key: 2"                , DK.TWO               },
            { "Key: 3"                , DK.THREE             },
            { "Key: 4"                , DK.FOUR              },
            { "Key: 5"                , DK.FIVE              },
            { "Key: 6"                , DK.SIX               },
            { "Key: 7"                , DK.SEVEN             },
            { "Key: 8"                , DK.EIGHT             },
            { "Key: 9"                , DK.NINE              },
            { "Key: 0"                , DK.ZERO              },
            { "Key: Enter"            , DK.ENTER             },//TODO: Fix
            { "Key: Enter (ISO)"      , DK.ENTER             },
            { "Key: Escape"           , DK.ESC               },
            { "Key: Backspace"        , DK.BACKSPACE         },
            { "Key: Tab"              , DK.TAB               },
            { "Key: Space"            , DK.SPACE             },
            { "Key: -"                , DK.MINUS             },
            { "Key: ="                , DK.EQUALS            },
            { "Key: ["                , DK.OPEN_BRACKET      },
            { "Key: ]"                , DK.CLOSE_BRACKET     },
            { "Key: \\ (ANSI)"        , DK.BACKSLASH         },
            { "Key: #"                , DK.HASHTAG           },
            { "Key: ;"                , DK.SEMICOLON         },
            { "Key: '"                , DK.APOSTROPHE        },
            { "Key: `"                , DK.TILDE             },
            { "Key: ,"                , DK.COMMA             },
            { "Key: ."                , DK.PERIOD            },
            { "Key: /"                , DK.FORWARD_SLASH     },
            { "Key: Caps Lock"        , DK.CAPS_LOCK         },
            { "Key: F1"               , DK.F1                },
            { "Key: F2"               , DK.F2                },
            { "Key: F3"               , DK.F3                },
            { "Key: F4"               , DK.F4                },
            { "Key: F5"               , DK.F5                },
            { "Key: F6"               , DK.F6                },
            { "Key: F7"               , DK.F7                },
            { "Key: F8"               , DK.F8                },
            { "Key: F9"               , DK.F9                },
            { "Key: F10"              , DK.F10               },
            { "Key: F11"              , DK.F11               },
            { "Key: F12"              , DK.F12               },
            { "Key: Print Screen"     , DK.PRINT_SCREEN      },
            { "Key: Scroll Lock"      , DK.SCROLL_LOCK       },
            { "Key: Pause/Break"      , DK.PAUSE_BREAK       },
            { "Key: Insert"           , DK.INSERT            },
            { "Key: Home"             , DK.HOME              },
            { "Key: Page Up"          , DK.PAGE_UP           },
            { "Key: Delete"           , DK.DELETE            },
            { "Key: End"              , DK.END               },
            { "Key: Page Down"        , DK.PAGE_DOWN         },
            { "Key: Right Arrow"      , DK.ARROW_RIGHT       },
            { "Key: Left Arrow"       , DK.ARROW_LEFT        },
            { "Key: Down Arrow"       , DK.ARROW_DOWN        },
            { "Key: Up Arrow"         , DK.ARROW_UP          },
            { "Key: Num Lock"         , DK.NUM_LOCK          },
            { "Key: Number Pad /"     , DK.NUM_SLASH         },
            { "Key: Number Pad *"     , DK.NUM_ASTERISK      },
            { "Key: Number Pad -"     , DK.NUM_MINUS         },
            { "Key: Number Pad +"     , DK.NUM_PLUS          },
            { "Key: Number Pad Enter" , DK.NUM_ENTER         },
            { "Key: Number Pad 1"     , DK.NUM_ONE           },
            { "Key: Number Pad 2"     , DK.NUM_TWO           },
            { "Key: Number Pad 3"     , DK.NUM_THREE         },
            { "Key: Number Pad 4"     , DK.NUM_FOUR          },
            { "Key: Number Pad 5"     , DK.NUM_FIVE          },
            { "Key: Number Pad 6"     , DK.NUM_SIX           },
            { "Key: Number Pad 7"     , DK.NUM_SEVEN         },
            { "Key: Number Pad 8"     , DK.NUM_EIGHT         },
            { "Key: Number Pad 9"     , DK.NUM_NINE          },
            { "Key: Number Pad 0"     , DK.NUM_ZERO          },
            { "Key: Number Pad ."     , DK.NUM_PERIOD        },
            { "Key: Left Fn"          , DK.LEFT_FN           },
            { "Key: Right Fn"         , DK.FN_Key            },
            { "Key: \\ (ISO)"         , DK.BACKSLASH_UK      },
            { "Key: Menu"             , DK.APPLICATION_SELECT},
            { "Key: Left Control"     , DK.LEFT_CONTROL      },
            { "Key: Left Shift"       , DK.LEFT_SHIFT        },
            { "Key: Left Alt"         , DK.LEFT_ALT          },
            { "Key: Left Windows"     , DK.LEFT_WINDOWS      },
            { "Key: Right Control"    , DK.RIGHT_CONTROL     },
            { "Key: Right Shift"      , DK.RIGHT_SHIFT       },
            { "Key: Right Alt"        , DK.RIGHT_ALT         },
            { "Key: Right Windows"    , DK.RIGHT_WINDOWS     },
            { "Key: Media Next"       , DK.MEDIA_NEXT        },
            { "Key: Media Previous"   , DK.MEDIA_PREVIOUS    },
            { "Key: Media Stop"       , DK.MEDIA_STOP        },
            { "Key: Media Pause"      , DK.MEDIA_PAUSE       },
            { "Key: Media Play"       , DK.MEDIA_PLAY        },
            { "Key: Media Play/Pause" , DK.MEDIA_PLAY_PAUSE  },
            { "Key: Media Mute"       , DK.VOLUME_MUTE       },
            { "Logo"                  , DK.LOGO              },
            { "Key: Brightness"       , DK.BRIGHTNESS_SWITCH },
            { "Key: M1"               , DK.G1                },
            { "Key: M2"               , DK.G2                },
            { "Key: M3"               , DK.G3                },
            { "Key: M4"               , DK.G4                },
            { "Key: M5"               , DK.G5                },
            { "Key: G0"               , DK.G0                },
            { "Key: G1"               , DK.G1                },
            { "Key: G2"               , DK.G2                },
            { "Key: G3"               , DK.G3                },
        };

        public static readonly Dictionary<string, DK> Mouse = new Dictionary<string, DK>()
        {
            { "Logo LED 1"           , DK.Peripheral_Logo        },
            { "Scroll Wheel LED 1"   , DK.Peripheral_ScrollWheel },
        };
    }
}
