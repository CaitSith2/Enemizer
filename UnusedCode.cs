﻿/*UNUSED CODE FOR SPRITES PALETTE RANDOMIZATION RESULT IS BAD NEED TO REWRITE THAT

/*for (int i = 0; i < 60; i++)
{
    if (changing[i] == 1)
    {
        setColor(0xDD218 + i * 2, Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)),0);
    }
}

for (int i = 0; i < aux_changing.Length; i++)
{
    if (aux_changing[i] == 1)
    {
        setColor(0xDD39E + i * 2, Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)),0);

    }
}


Color c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));

c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD21A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD21C, c, 4);
            setColor(0x0DD21E, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD222, c, 4);
            setColor(0x0DD224, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD22A, c, 6);
            setColor(0x0DD22C, c, 4);
            setColor(0x0DD22E, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD232, c, 4);
            setColor(0x0DD234, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD238, c, 6);
            setColor(0x0DD23A, c, 4);
            setColor(0x0DD23C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD240, c, 4);
            setColor(0x0DD242, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD248, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD24A, c, 4);
            setColor(0x0DD24C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD250, c, 4);
            setColor(0x0DD252, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD256, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD258, c, 4);
            setColor(0x0DD25A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD25E, c, 4);
            setColor(0x0DD260, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD274, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD276, c, 4);
            setColor(0x0DD278, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD27C, c, 4);
            setColor(0x0DD27E, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD284, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD286, c, 4);
            setColor(0x0DD288, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD28C, c, 4);
            setColor(0x0DD28E, c, 2);


c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD292, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD294, c, 4);
            setColor(0x0DD296, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD29A, c, 4);
            setColor(0x0DD29C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2A2, c, 6);
            setColor(0x0DD2A4, c, 4);
            setColor(0x0DD2A6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2AA, c, 4);
            setColor(0x0DD2AC, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2B0, c, 6);
            setColor(0x0DD2B2, c, 4);
            setColor(0x0DD2B4, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2B8, c, 4);
            setColor(0x0DD2BA, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2C0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2C2, c, 4);
            setColor(0x0DD2C4, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2C8, c, 4);
            setColor(0x0DD2CA, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2CE, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2D0, c, 4);
            setColor(0x0DD2D2, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2D6, c, 4);
            setColor(0x0DD2D8, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2EC, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2EE, c, 4);
            setColor(0x0DD2F0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2F4, c, 4);
            setColor(0x0DD2F6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2FC, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD2FE, c, 4);
            setColor(0x0DD300, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD304, c, 4);
            setColor(0x0DD306, c, 2);






//Color c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD39E, c, 6);
            setColor(0x0DD3A0, c, 4);
            setColor(0x0DD3A2, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3A4, c, 4);
            setColor(0x0DD3A6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3A8, c, 4);
            setColor(0x0DD3AA, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3AE, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3B0, c, 4);
            setColor(0x0DD3B2, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3B6, c, 4);
            setColor(0x0DD3B8, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3BA, c, 4);
            setColor(0x0DD3BC, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3BE, c, 4);
            setColor(0x0DD3C0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3C4, c, 4);
            setColor(0x0DD3C6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3C8, c, 4);
            setColor(0x0DD3CA, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3CC, c, 4);
            setColor(0x0DD3CE, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3D2, c, 4);
            setColor(0x0DD3D4, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3D6, c, 4);
            setColor(0x0DD3D8, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3DA, c, 4);
            setColor(0x0DD3DC, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3E0, c, 4);
            setColor(0x0DD3E2, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3E6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3E8, c, 4);
            setColor(0x0DD3EA, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3EE, c, 4);
            setColor(0x0DD3F0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3F4, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3F6, c, 4);
            setColor(0x0DD3F8, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD3FC, c, 4);
            setColor(0x0DD3FE, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD402, c, 6);
            setColor(0x0DD404, c, 4);
            setColor(0x0DD406, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD40A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD40C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD410, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD412, c, 4);
            setColor(0x0DD414, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD418, c, 4);
            setColor(0x0DD41A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD41E, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD420, c, 4);
            setColor(0x0DD422, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD426, c, 4);
            setColor(0x0DD428, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD42C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD42E, c, 4);
            setColor(0x0DD430, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD434, c, 4);
            setColor(0x0DD436, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD43A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD43C, c, 4);
            setColor(0x0DD43E, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD442, c, 4);
            setColor(0x0DD444, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD446, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD448, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD44A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD44C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD44E, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD450, c, 4);
            setColor(0x0DD452, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD454, c, 4);
            setColor(0x0DD456, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD458, c, 6);
            setColor(0x0DD45A, c, 4);
            setColor(0x0DD45C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD462, c, 4);
            setColor(0x0DD464, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD466, c, 6);
            setColor(0x0DD468, c, 4);
            setColor(0x0DD46A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD470, c, 4);
            setColor(0x0DD472, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD474, c, 6);
            setColor(0x0DD476, c, 4);
            setColor(0x0DD478, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD486, c, 6);
            setColor(0x0DD488, c, 4);
            setColor(0x0DD48A, c, 2);


c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4E2, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4E4, c, 4);
            setColor(0x0DD4E6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4EA, c, 4);
            setColor(0x0DD4EC, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4F0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4F2, c, 4);
            setColor(0x0DD4F4, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4F8, c, 4);
            setColor(0x0DD4FA, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4FE, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD500, c, 4);
            setColor(0x0DD502, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD506, c, 4);
            setColor(0x0DD508, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD50C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD50E, c, 4);
            setColor(0x0DD510, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD514, c, 4);
            setColor(0x0DD516, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD51A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD51C, c, 4);
            setColor(0x0DD51E, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD522, c, 4);
            setColor(0x0DD524, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD528, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD52A, c, 4);
            setColor(0x0DD52C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD530, c, 4);
            setColor(0x0DD532, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD536, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD538, c, 4);
            setColor(0x0DD53A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD53E, c, 4);
            setColor(0x0DD540, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD544, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD546, c, 4);
            setColor(0x0DD548, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD54C, c, 4);
            setColor(0x0DD54E, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD552, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD554, c, 4);
            setColor(0x0DD556, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD55A, c, 4);
            setColor(0x0DD55C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD560, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD562, c, 4);
            setColor(0x0DD564, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD568, c, 4);
            setColor(0x0DD56A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD56E, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD570, c, 4);
            setColor(0x0DD572, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD576, c, 4);
            setColor(0x0DD578, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD57C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD57E, c, 4);
            setColor(0x0DD580, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD584, c, 4);
            setColor(0x0DD586, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD58A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD58C, c, 4);
            setColor(0x0DD58E, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD592, c, 4);
            setColor(0x0DD594, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD598, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD59A, c, 4);
            setColor(0x0DD59C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5A0, c, 4);
            setColor(0x0DD5A2, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5A6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5A8, c, 4);
            setColor(0x0DD5AA, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5AE, c, 4);
            setColor(0x0DD5B0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5B4, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5B6, c, 4);
            setColor(0x0DD5B8, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5BC, c, 4);
            setColor(0x0DD5BE, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5C2, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5C4, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5C6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5CA, c, 4);
            setColor(0x0DD5CC, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5D0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5D2, c, 4);
            setColor(0x0DD5D4, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5D8, c, 4);
            setColor(0x0DD5DA, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5DC, c, 4);
            setColor(0x0DD5DE, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5E0, c, 4);
            setColor(0x0DD5E2, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5E8, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5EC, c, 6);
            setColor(0x0DD5EE, c, 4);
            setColor(0x0DD5F0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5F4, c, 4);
            setColor(0x0DD5F6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD5FA, c, 6);
            setColor(0x0DD5FC, c, 4);
            setColor(0x0DD5FE, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD602, c, 4);
            setColor(0x0DD604, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD608, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD60A, c, 4);
            setColor(0x0DD60C, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD610, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD612, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD616, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD618, c, 4);
            setColor(0x0DD61A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD61E, c, 4);
            setColor(0x0DD620, c, 2);


Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD482, c, 4);
            setColor(0x0DD484, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD488, c, 4);
            setColor(0x0DD48A, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD48E, c, 4);
            setColor(0x0DD490, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD492, c, 8);
            setColor(0x0DD494, c, 6);
            setColor(0x0DD496, c, 4);
            setColor(0x0DD498, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD49C, c, 6);
            setColor(0x0DD49E, c, 4);
            setColor(0x0DD4A0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4A2, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4A4, c, 4);
            setColor(0x0DD4A6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4AC, c, 4);
            setColor(0x0DD4AE, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4B0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4B2, c, 4);
            setColor(0x0DD4B4, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4B6, c, 4);
            setColor(0x0DD4B8, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4BA, c, 4);
            setColor(0x0DD4BC, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4BE, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4C0, c, 4);
            setColor(0x0DD4C2, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4C4, c, 4);
            setColor(0x0DD4C6, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4C8, c, 6);
            setColor(0x0DD4CA, c, 4);
            setColor(0x0DD4CC, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4CE, c, 4);
            setColor(0x0DD4D0, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4D2, c, 4);
            setColor(0x0DD4D4, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4D6, c, 4);
            setColor(0x0DD4D8, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4DA, c, 2);
c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            setColor(0x0DD4DC, c, 4);
            setColor(0x0DD4DE, c, 2);


*/