using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour {

	// ************************ Attribute Plane ************************
	public const int TOTAL_PLANE 		= 17;
	public const int TOTAL_PLANE_ATT 	= 5;

	public const int CLASS_PLANE  		= 0;
	public const int HP_PLANE      		= 1;
	public const int DAMGE_PLANE  		= 2;
	public const int DAMGE_SPEC_PLANE 	= 3;
	public const int FIRE_RATE_PLANE 	= 4;


	public const int CLASS_C = 1;
	public const int CLASS_B = 2;
	public const int CLASS_A = 3;
	public const int CLASS_S = 4;

	public static int[,] PLANE_ATT = new int[TOTAL_PLANE, TOTAL_PLANE_ATT]
	{ 
		{ 1,  210,  63, 152, 10 }, // 0 // Class(C:1, B:2, A:3, S:4), HP, Damge, Special Damge, Fire Rate v/s
		{ 2,  293, 115, 146, 10},
		{ 2,  639,  55, 165, 10},
		{ 2,  403,  96, 165, 10},
		{ 2,  499,  83, 134, 10}, 
		{ 2,  162, 142, 134, 10}, // 5
		{ 3,  483, 248, 152, 10},
		{ 3,  408, 265, 142, 10},
		{ 3,  489, 254, 134, 10},
		{ 3,  885, 188, 128, 10}, 
		{ 3,  884, 187, 130, 10}, // 10
		{ 3,  408, 211, 418, 10},
		{ 4, 1058, 215, 137, 10},
		{ 4, 1064, 220, 121, 10},
		{ 4, 1064, 220, 121, 10},
		{ 4, 1052, 210, 153, 10}, // 15
		{ 4, 1052, 210, 153, 10}
	};
	// ************************ End Attribte Plane ************************


	//  ************************ Attribute Bot ************************

	// ************************ End Attribute Bot ************************


	//  ************************ Attribute Enemy ************************
	public const int TOTAL_LEVEL_ENEMY 	= 2;
	public const int TOTAL_ENEMY_ATT 	= 6;

	public const int SPEED_ENEMY		= 0;
	public const int TYPE_SHOOT_ENEMY	= 1;
	public const int TYPE_BULLET_ENEMY 	= 2;
	public const int SPEED_BULLET_ENEMY = 3;
	public const int HP_ENEMY 			= 4;
	public const int BONUS_ENEMY 		= 5;


	public static int[,] E1_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 5,   0,   0,   0,  12,   1 }, // speed, shootStyle, bulletStyle, bulletSpeed, HP, Bonus. 
		{ 0,   0,   0,   0,   0,   0 }
	};
	public static int[,] E2_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 7,   0,   0,   0,   2,   2 }, // speed, shootStyle, bulletStyle, bulletSpeed, HP, Bonus. 
		{ 0,   0,   0,   0,   0,   0 }
	};
	public static int[,] E3_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 5,   1,   1,   1,   2,   3 },
		{ 0,   0,   0,   0,   0,   0 }
	};
	public static int[,] E4_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 5,   0,   0,   0,   5,   4 },
		{ 0,   0,   0,   0,   0,   0 }
	};
	public static int[,] E5_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 5,   0,   0,   0,   1,   1 },
		{ 0,   0,   0,   0,   0,   0 }
	};
	public static int[,] E6_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 2,   0,   0,   0,   2,   1 },
		{ 0,   0,   0,   0,   0,   0 }
	};
	public static int[,] E7_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 1,   1,   1,   1,   8,   1 },
		{ 0,   0,   0,   0,   0,   0}
	};
	// ************************ End Attribute Enemy ************************
}
