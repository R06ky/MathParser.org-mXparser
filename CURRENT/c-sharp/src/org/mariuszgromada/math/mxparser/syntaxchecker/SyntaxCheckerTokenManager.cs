/* Generated By: CSCC: 4.0 (03/25/2012)  Do not edit this line. SyntaxCheckerTokenManager.cs */
namespace org.mariuszgromada.math.mxparser.syntaxchecker{
using System;
using System.IO;

public class SyntaxCheckerTokenManager : SyntaxCheckerConstants
{
#if PCL || NETSTANDARD
	public System.IO.TextWriter debugStream = new System.IO.StreamWriter(new System.IO.MemoryStream());
#else
	public  System.IO.TextWriter debugStream = new System.IO.StreamWriter(System.Console.OpenStandardError());
#endif
	public void setDebugStream(System.IO.TextWriter ds) { debugStream = ds; }
private int jjStopStringLiteralDfa_0(int pos, long active0)
{
   switch (pos)
   {
      case 0:
         if ((active0 & 0x1000000000000L) != 0L)
            return 58;
         if ((active0 & 0x80000000L) != 0L)
            return 62;
         if ((active0 & 0x10000L) != 0L)
            return 16;
         if ((active0 & 0x2000L) != 0L)
            return 72;
         if ((active0 & 0x100000000L) != 0L)
         {
            jjmatchedKind = 42;
            return 49;
         }
         if ((active0 & 0x5406000000L) != 0L)
            return 3;
         if ((active0 & 0xa00004000L) != 0L)
            return 73;
         if ((active0 & 0x80000L) != 0L)
            return 5;
         return -1;
      case 1:
         if ((active0 & 0x200000000L) != 0L)
         {
            jjmatchedKind = 50;
            jjmatchedPos = 1;
            return -1;
         }
         return -1;
      default :
         return -1;
   }
}
private int jjStartNfa_0(int pos, long active0)
{
   return jjMoveNfa_0(jjStopStringLiteralDfa_0(pos, active0), pos + 1);
}
private int jjStopAtPos(int pos, int kind)
{
   jjmatchedKind = kind;
   jjmatchedPos = pos;
   return pos + 1;
}
private int jjStartNfaWithStates_0(int pos, int kind, int state)
{
   jjmatchedKind = kind;
   jjmatchedPos = pos;
   try { curChar = input_stream.readChar(); }
   catch(System.IO.IOException e) {
		#if PCL || CORE || NETSTANDARD || ANDROID || IOS
			mXparser.doNothing(e);
		#endif
		return pos + 1;
	}
   return jjMoveNfa_0(state, pos + 1);
}
private int jjMoveStringLiteralDfa0_0()
{
   switch((int)curChar)
   {
      case 33:
         return jjStartNfaWithStates_0(0, 19, 5);
      case 35:
         return jjStopAtPos(0, 18);
      case 40:
         jjmatchedKind = 11;
         return jjMoveStringLiteralDfa1_0(0x20000000000L);
      case 41:
         return jjStopAtPos(0, 12);
      case 42:
         return jjStopAtPos(0, 15);
      case 43:
         return jjStartNfaWithStates_0(0, 13, 72);
      case 44:
         return jjStopAtPos(0, 20);
      case 45:
         jjmatchedKind = 14;
         return jjMoveStringLiteralDfa1_0(0xa00000000L);
      case 47:
         return jjStartNfaWithStates_0(0, 16, 16);
      case 59:
         return jjStopAtPos(0, 21);
      case 60:
         jjmatchedKind = 25;
         return jjMoveStringLiteralDfa1_0(0x5404000000L);
      case 62:
         jjmatchedKind = 27;
         return jjMoveStringLiteralDfa1_0(0x10000000L);
      case 64:
         return jjMoveStringLiteralDfa1_0(0x100000000L);
      case 91:
         return jjStartNfaWithStates_0(0, 48, 58);
      case 93:
         return jjStopAtPos(0, 49);
      case 94:
         return jjStopAtPos(0, 17);
      case 126:
         return jjStartNfaWithStates_0(0, 31, 62);
      default :
         return jjMoveNfa_0(0, 0);
   }
}
private int jjMoveStringLiteralDfa1_0(long active0)
{
   try { curChar = input_stream.readChar(); }
   catch(System.IO.IOException e) {
	#if PCL || CORE || NETSTANDARD || ANDROID || IOS
		mXparser.doNothing(e);
	#endif
	  jjStopStringLiteralDfa_0(0, active0);
      return 1;
   }
   switch((int)curChar)
   {
      case 43:
         return jjMoveStringLiteralDfa2_0(active0, 0x20000000000L);
      case 45:
         return jjMoveStringLiteralDfa2_0(active0, 0x4600000000L);
      case 47:
         return jjMoveStringLiteralDfa2_0(active0, 0x1800000000L);
      case 61:
         if ((active0 & 0x4000000L) != 0L)
            return jjStopAtPos(1, 26);
         else if ((active0 & 0x10000000L) != 0L)
            return jjStopAtPos(1, 28);
         break;
      case 126:
         if ((active0 & 0x100000000L) != 0L)
            return jjStopAtPos(1, 32);
         break;
      default :
         break;
   }
   return jjStartNfa_0(0, active0);
}
private int jjMoveStringLiteralDfa2_0(long old0, long active0)
{
   if (((active0 &= old0)) == 0L)
      return jjStartNfa_0(0, old0);
   try { curChar = input_stream.readChar(); }
   catch(System.IO.IOException e) {
		#if PCL || CORE || NETSTANDARD || ANDROID || IOS
			mXparser.doNothing(e);
		#endif
		jjStopStringLiteralDfa_0(1, active0);
      return 2;
   }
   switch((int)curChar)
   {
      case 41:
         if ((active0 & 0x20000000000L) != 0L)
            return jjStopAtPos(2, 41);
         break;
      case 45:
         if ((active0 & 0x400000000L) != 0L)
            return jjStopAtPos(2, 34);
         else if ((active0 & 0x1000000000L) != 0L)
            return jjStopAtPos(2, 36);
         break;
      case 62:
         if ((active0 & 0x200000000L) != 0L)
            return jjStopAtPos(2, 33);
         else if ((active0 & 0x800000000L) != 0L)
            return jjStopAtPos(2, 35);
         else if ((active0 & 0x4000000000L) != 0L)
            return jjStopAtPos(2, 38);
         break;
      default :
         break;
   }
   return jjStartNfa_0(1, active0);
}
private void jjCheckNAdd(int state)
{
   if (jjrounds[state] != jjround)
   {
      jjstateSet[jjnewStateCnt++] = state;
      jjrounds[state] = jjround;
   }
}
private void jjAddStates(int start, int end)
{
   do {
      jjstateSet[jjnewStateCnt++] = jjnextStates[start];
   } while (start++ != end);
}
private void jjCheckNAddTwoStates(int state1, int state2)
{
   jjCheckNAdd(state1);
   jjCheckNAdd(state2);
}
private void jjCheckNAddStates(int start, int end)
{
   do {
      jjCheckNAdd(jjnextStates[start]);
   } while (start++ != end);
}
private void jjCheckNAddStates(int start)
{
   jjCheckNAdd(jjnextStates[start]);
   jjCheckNAdd(jjnextStates[start + 1]);
}
private int jjMoveNfa_0(int startState, int curPos)
{
#if !PCL && !CORE && !NETSTANDARD && !ANDROID && !IOS
	int[] nextStates;
#endif
            int startsAt = 0;
   jjnewStateCnt = 72;
   int i = 1;
   jjstateSet[0] = startState;
   #if !PCL && !CORE && !NETSTANDARD && !ANDROID && !IOS
	int j;
   #endif
   int kind = 0x7fffffff;
   for (;;)
   {
      if (++jjround == 0x7fffffff)
         ReInitRounds();
      if (curChar < 64)
      {
         ulong l = 1UL << curChar;
		#if !PCL && !CORE && !NETSTANDARD && !ANDROID && !IOS
			MatchLoop:
		#endif
		 do
         {
            switch(jjstateSet[--i])
            {
               case 72:
                  if (curChar == 45)
                  {
                     if (kind > 50)
                        kind = 50;
                  }
                  else if (curChar == 43)
                  {
                     if (kind > 50)
                        kind = 50;
                  }
                  break;
               case 62:
                  if (curChar == 47)
                     jjstateSet[jjnewStateCnt++] = 65;
                  else if (curChar == 38)
                     jjstateSet[jjnewStateCnt++] = 63;
                  else if (curChar == 61)
                  {
                     if (kind > 24)
                        kind = 24;
                  }
                  if (curChar == 38)
                  {
                     if (kind > 37)
                        kind = 37;
                  }
                  break;
               case 0:
                  if ((0x3fe000000000000L & l) != 0L)
                  {
                     if (kind > 45)
                        kind = 45;
                     jjCheckNAddStates(0, 3);
                  }
                  else if ((0x8c00c09800000000L & l) != 0L)
                  {
                     if (kind > 42)
                        kind = 42;
                  }
                  else if (curChar == 48)
                  {
                     if (kind > 45)
                        kind = 45;
                     jjCheckNAddTwoStates(43, 21);
                  }
                  else if (curChar == 45)
                     jjCheckNAddTwoStates(33, 32);
                  else if (curChar == 43)
                     jjCheckNAddTwoStates(32, 33);
                  else if (curChar == 38)
                     jjstateSet[jjnewStateCnt++] = 14;
                  else if (curChar == 33)
                     jjstateSet[jjnewStateCnt++] = 5;
                  else if (curChar == 60)
                     jjstateSet[jjnewStateCnt++] = 3;
                  else if (curChar == 61)
                     jjstateSet[jjnewStateCnt++] = 1;
                  if (curChar == 48)
                     jjstateSet[jjnewStateCnt++] = 19;
                  else if (curChar == 47)
                     jjstateSet[jjnewStateCnt++] = 16;
                  else if (curChar == 38)
                  {
                     if (kind > 30)
                        kind = 30;
                  }
                  else if (curChar == 61)
                  {
                     if (kind > 22)
                        kind = 22;
                  }
                  break;
               case 73:
                  if (curChar == 43)
                  {
                     if (kind > 50)
                        kind = 50;
                  }
                  else if (curChar == 45)
                  {
                     if (kind > 50)
                        kind = 50;
                  }
                  break;
               case 49:
                  if (curChar == 62)
                     jjstateSet[jjnewStateCnt++] = 54;
                  else if (curChar == 60)
                     jjstateSet[jjnewStateCnt++] = 52;
                  else if (curChar == 38)
                  {
                     if (kind > 40)
                        kind = 40;
                  }
                  break;
               case 58:
                  if (curChar == 37)
                     jjstateSet[jjnewStateCnt++] = 59;
                  if (curChar == 37)
                     jjCheckNAdd(57);
                  break;
               case 1:
                  if (curChar == 61 && kind > 22)
                     kind = 22;
                  break;
               case 2:
                  if (curChar == 61)
                     jjstateSet[jjnewStateCnt++] = 1;
                  break;
               case 3:
                  if (curChar == 62 && kind > 24)
                     kind = 24;
                  break;
               case 4:
                  if (curChar == 60)
                     jjstateSet[jjnewStateCnt++] = 3;
                  break;
               case 5:
                  if (curChar == 61 && kind > 24)
                     kind = 24;
                  break;
               case 6:
                  if (curChar == 33)
                     jjstateSet[jjnewStateCnt++] = 5;
                  break;
               case 11:
                  if (curChar == 47 && kind > 29)
                     kind = 29;
                  break;
               case 13:
               case 14:
                  if (curChar == 38 && kind > 30)
                     kind = 30;
                  break;
               case 15:
                  if (curChar == 38)
                     jjstateSet[jjnewStateCnt++] = 14;
                  break;
               case 17:
                  if (curChar == 47)
                     jjstateSet[jjnewStateCnt++] = 16;
                  break;
               case 18:
                  if ((0x8c00c09800000000L & l) != 0L && kind > 42)
                     kind = 42;
                  break;
               case 19:
                  if (curChar == 46)
                     jjCheckNAdd(20);
                  break;
               case 20:
                  if ((0x3ff000000000000L & l) == 0L)
                     break;
                  if (kind > 45)
                     kind = 45;
                  jjCheckNAddTwoStates(20, 21);
                  break;
               case 22:
                  if ((0x280000000000L & l) != 0L)
                     jjAddStates(4, 5);
                  break;
               case 23:
                  if (curChar == 48 && kind > 45)
                     kind = 45;
                  break;
               case 24:
                  if ((0x3fe000000000000L & l) == 0L)
                     break;
                  if (kind > 45)
                     kind = 45;
                  jjCheckNAdd(25);
                  break;
               case 25:
                  if ((0x3ff000000000000L & l) == 0L)
                     break;
                  if (kind > 45)
                     kind = 45;
                  jjCheckNAdd(25);
                  break;
               case 26:
                  if (curChar == 48)
                     jjstateSet[jjnewStateCnt++] = 19;
                  break;
               case 28:
                  if ((0x3ff000000000000L & l) == 0L)
                     break;
                  if (kind > 46)
                     kind = 46;
                  jjAddStates(6, 7);
                  break;
               case 31:
                  if (curChar == 43)
                     jjCheckNAddTwoStates(32, 33);
                  break;
               case 32:
                  if (curChar == 43 && kind > 50)
                     kind = 50;
                  break;
               case 33:
                  if (curChar == 45 && kind > 50)
                     kind = 50;
                  break;
               case 34:
                  if (curChar == 45)
                     jjCheckNAddTwoStates(33, 32);
                  break;
               case 36:
                  if (curChar == 43 && kind > 47)
                     kind = 47;
                  break;
               case 39:
                  if (curChar == 45 && kind > 47)
                     kind = 47;
                  break;
               case 42:
                  if (curChar != 48)
                     break;
                  if (kind > 45)
                     kind = 45;
                  jjCheckNAddTwoStates(43, 21);
                  break;
               case 43:
                  if (curChar == 46)
                     jjCheckNAdd(44);
                  break;
               case 44:
                  if ((0x3ff000000000000L & l) == 0L)
                     break;
                  if (kind > 45)
                     kind = 45;
                  jjCheckNAddTwoStates(44, 21);
                  break;
               case 45:
                  if ((0x3fe000000000000L & l) == 0L)
                     break;
                  if (kind > 45)
                     kind = 45;
                  jjCheckNAddStates(0, 3);
                  break;
               case 46:
                  if ((0x3ff000000000000L & l) != 0L)
                     jjCheckNAddTwoStates(46, 43);
                  break;
               case 47:
                  if ((0x3ff000000000000L & l) == 0L)
                     break;
                  if (kind > 45)
                     kind = 45;
                  jjCheckNAddTwoStates(47, 21);
                  break;
               case 52:
                  if (curChar == 60 && kind > 40)
                     kind = 40;
                  break;
               case 53:
                  if (curChar == 60)
                     jjstateSet[jjnewStateCnt++] = 52;
                  break;
               case 54:
                  if (curChar == 62 && kind > 40)
                     kind = 40;
                  break;
               case 55:
                  if (curChar == 62)
                     jjstateSet[jjnewStateCnt++] = 54;
                  break;
               case 59:
                  if (curChar == 37)
                     jjCheckNAdd(57);
                  break;
               case 60:
                  if (curChar == 37)
                     jjstateSet[jjnewStateCnt++] = 59;
                  break;
               case 63:
                  if (curChar == 38 && kind > 37)
                     kind = 37;
                  break;
               case 64:
                  if (curChar == 38)
                     jjstateSet[jjnewStateCnt++] = 63;
                  break;
               case 66:
                  if (curChar == 47)
                     jjstateSet[jjnewStateCnt++] = 65;
                  break;
               case 70:
                  if (curChar == 47 && kind > 39)
                     kind = 39;
                  break;
               default : break;
            }
         } while(i != startsAt);
      }
      else if (curChar < 128)
      {
         ulong l = 1UL << (curChar & 0x3F);
		#if !PCL && !CORE && !NETSTANDARD && !ANDROID && !IOS
			MatchLoop:
		#endif
		do
         {
            switch(jjstateSet[--i])
            {
               case 62:
                  if (curChar == 92)
                     jjstateSet[jjnewStateCnt++] = 70;
                  else if (curChar == 124)
                     jjstateSet[jjnewStateCnt++] = 68;
                  if (curChar == 124)
                  {
                     if (kind > 39)
                        kind = 39;
                  }
                  break;
               case 0:
                  if ((0x7fffffe87fffffeL & l) != 0L)
                  {
                     if (kind > 46)
                        kind = 46;
                     jjCheckNAddTwoStates(28, 30);
                  }
                  else if ((0x110000001L & l) != 0L)
                  {
                     if (kind > 42)
                        kind = 42;
                  }
                  else if (curChar == 126)
                     jjAddStates(8, 13);
                  else if (curChar == 91)
                     jjAddStates(14, 15);
                  else if (curChar == 124)
                     jjstateSet[jjnewStateCnt++] = 9;
                  if (curChar == 64)
                     jjAddStates(16, 20);
                  else if (curChar == 100)
                     jjAddStates(21, 22);
                  else if (curChar == 92)
                     jjstateSet[jjnewStateCnt++] = 11;
                  else if (curChar == 124)
                  {
                     if (kind > 29)
                        kind = 29;
                  }
                  else if (curChar == 126)
                     jjstateSet[jjnewStateCnt++] = 5;
                  break;
               case 49:
                  if (curChar == 124)
                  {
                     if (kind > 40)
                        kind = 40;
                  }
                  else if (curChar == 94)
                  {
                     if (kind > 40)
                        kind = 40;
                  }
                  break;
               case 7:
                  if (curChar == 126)
                     jjstateSet[jjnewStateCnt++] = 5;
                  break;
               case 8:
               case 9:
                  if (curChar == 124 && kind > 29)
                     kind = 29;
                  break;
               case 10:
                  if (curChar == 124)
                     jjstateSet[jjnewStateCnt++] = 9;
                  break;
               case 12:
                  if (curChar == 92)
                     jjstateSet[jjnewStateCnt++] = 11;
                  break;
               case 16:
                  if (curChar == 92 && kind > 30)
                     kind = 30;
                  break;
               case 18:
                  if ((0x110000001L & l) != 0L && kind > 42)
                     kind = 42;
                  break;
               case 21:
                  if ((0x2000000020L & l) != 0L)
                     jjAddStates(23, 25);
                  break;
               case 27:
                  if ((0x7fffffe87fffffeL & l) == 0L)
                     break;
                  if (kind > 46)
                     kind = 46;
                  jjCheckNAddTwoStates(28, 30);
                  break;
               case 29:
                  if ((0x7fffffe87fffffeL & l) == 0L)
                     break;
                  if (kind > 46)
                     kind = 46;
                  jjCheckNAddTwoStates(28, 29);
                  break;
               case 30:
                  if ((0x7fffffe87fffffeL & l) == 0L)
                     break;
                  if (kind > 46)
                     kind = 46;
                  jjCheckNAddStates(26, 28);
                  break;
               case 35:
                  if (curChar == 100)
                     jjAddStates(21, 22);
                  break;
               case 37:
                  if (curChar == 114)
                     jjstateSet[jjnewStateCnt++] = 36;
                  break;
               case 38:
                  if (curChar == 101)
                     jjstateSet[jjnewStateCnt++] = 37;
                  break;
               case 40:
                  if (curChar == 114)
                     jjstateSet[jjnewStateCnt++] = 39;
                  break;
               case 41:
                  if (curChar == 101)
                     jjstateSet[jjnewStateCnt++] = 40;
                  break;
               case 48:
                  if (curChar == 64)
                     jjAddStates(16, 20);
                  break;
               case 50:
                  if (curChar == 94)
                     kind = 40;
                  break;
               case 51:
                  if (curChar == 124 && kind > 40)
                     kind = 40;
                  break;
               case 56:
                  if (curChar == 91)
                     jjAddStates(14, 15);
                  break;
               case 57:
                  if (curChar == 93)
                     kind = 23;
                  break;
               case 61:
                  if (curChar == 126)
                     jjAddStates(8, 13);
                  break;
               case 65:
                  if (curChar == 92 && kind > 37)
                     kind = 37;
                  break;
               case 67:
               case 68:
                  if (curChar == 124 && kind > 39)
                     kind = 39;
                  break;
               case 69:
                  if (curChar == 124)
                     jjstateSet[jjnewStateCnt++] = 68;
                  break;
               case 71:
                  if (curChar == 92)
                     jjstateSet[jjnewStateCnt++] = 70;
                  break;
               default : break;
            }
         } while(i != startsAt);
      }
      else
      {
         int i2 = (curChar & 0xff) >> 6;
         ulong l2 = 1UL << (curChar & 0x3F);
		#if !PCL && !CORE && !NETSTANDARD && !ANDROID && !IOS
			MatchLoop:
		#endif
		do
         {
            switch(jjstateSet[--i])
            {
               default : break;
            }
         } while(i != startsAt);
      }
      if (kind != 0x7fffffff)
      {
         jjmatchedKind = kind;
         jjmatchedPos = curPos;
         kind = 0x7fffffff;
      }
      ++curPos;
      if ((i = jjnewStateCnt) == (startsAt = 72 - (jjnewStateCnt = startsAt)))
         return curPos;
      try { curChar = input_stream.readChar(); }
      catch(System.IO.IOException e) {
		#if PCL || CORE || NETSTANDARD || ANDROID || IOS
			mXparser.doNothing(e);
		#endif
			return curPos;
	}
   }
}
static int[] jjnextStates = {
   46, 43, 47, 21, 23, 24, 29, 28, 62, 64, 66, 67, 69, 71, 58, 60,
   49, 50, 51, 53, 55, 38, 41, 22, 23, 24, 28, 29, 30,
};
public static String[] jjstrLiteralImages = {
"", null, null, null, null, null, null, null, null, null, null, "\x28",
"\x29", "\x2b", "\x2d", "\x2a", "\x2f", "\x5e", "\x23", "\x21", "\x2c", "\x3b", null,
null, null, "\x3c", "\x3c\x3d", "\x3e", "\x3e\x3d", null, null, "\x7e", "\x40\x7e",
"\x2d\x2d\x3e", "\x3c\x2d\x2d", "\x2d\x2f\x3e", "\x3c\x2f\x2d", null, "\x3c\x2d\x3e", null,
null, "\x28\x2b\x29", null, null, null, null, null, null, "\x5b", "\x5d", null, null, };
public static String[] lexStateNames = {
   "DEFAULT",
};
static long[] jjtoToken = {
   0xfe7fffffff801L,
};
static long[] jjtoSkip = {
   0x1eL,
};
protected SimpleCharStream input_stream;
private long[] jjrounds = new long[72];
private int[] jjstateSet = new int[144];
protected char curChar;
public SyntaxCheckerTokenManager(SimpleCharStream stream){
   if (SimpleCharStream.staticFlag)
      throw new Exception("ERROR: Cannot use a static CharStream class with a non-static lexical analyzer.");
   input_stream = stream;
}
public SyntaxCheckerTokenManager(SimpleCharStream stream, int lexState) : this(stream){
   SwitchTo(lexState);
}
public void ReInit(SimpleCharStream stream)
{
   jjmatchedPos = jjnewStateCnt = 0;
   curLexState = defaultLexState;
   input_stream = stream;
   ReInitRounds();
}
private void ReInitRounds()
{
   int i;
   jjround = 0x80000001;
   for (i = 72; i-- > 0;)
      jjrounds[i] = 0x80000000;
}
public void ReInit(SimpleCharStream stream, int lexState)
{
   ReInit(stream);
   SwitchTo(lexState);
}
public void SwitchTo(int lexState)
{
   if (lexState >= 1 || lexState < 0)
      throw new TokenMgrError("Error: Ignoring invalid lexical state : " + lexState + ". State unchanged.", TokenMgrError.INVALID_LEXICAL_STATE);
   else
      curLexState = lexState;
}

protected Token jjFillToken(){
   String im = jjstrLiteralImages[jjmatchedKind];
   String curTokenIm;
   int beginLine;
   int beginColumn;
   int endLine;
   int endColumn;
   curTokenIm = (im == null) ? input_stream.GetImage() : im;
   beginLine = input_stream.getBeginLine();
   beginColumn = input_stream.getBeginColumn();
   endLine = input_stream.getEndLine();
   endColumn = input_stream.getEndColumn();

   Token t = Token.newToken(jjmatchedKind, curTokenIm);
   t.beginLine = beginLine;
   t.beginColumn = beginColumn;
   t.endLine = endLine;
   t.endColumn = endColumn;
   return t;
}

int curLexState = 0;
int defaultLexState = 0;
int jjnewStateCnt;
long jjround;
int jjmatchedPos;
int jjmatchedKind;

public Token getNextToken()
{
#if !PCL && !CORE && !NETSTANDARD && !ANDROID && !IOS
  int kind;
  Token specialToken = null;
#endif
            Token matchedToken;
  int curPos = 0;

  EOFLoop :
  for (;;){
   try{
      curChar = input_stream.BeginToken();
   }catch(System.IO.IOException e){
        #if PCL || CORE || NETSTANDARD || ANDROID || IOS
			mXparser.doNothing(e);
        #endif
      jjmatchedKind = 0;
      matchedToken = jjFillToken();
      return matchedToken;
   }

   try { input_stream.backup(0);
      while (curChar <= 32 && (0x100002600L & (1L << curChar)) != 0L)
         curChar = input_stream.BeginToken();
   }
   catch (System.IO.IOException e1) {
        #if PCL || CORE || NETSTANDARD || ANDROID || IOS
                    mXparser.doNothing(e1);
		#endif
		goto EOFLoop;
	}
   jjmatchedKind = 0x7fffffff;
   jjmatchedPos = 0;
   curPos = jjMoveStringLiteralDfa0_0();
   if (jjmatchedPos == 0 && jjmatchedKind > 51)
   {
      jjmatchedKind = 51;
   }
   if (jjmatchedKind != 0x7fffffff){
      if (jjmatchedPos + 1 < curPos)
         input_stream.backup(curPos - jjmatchedPos - 1);
      if (((ulong)jjtoToken[jjmatchedKind >> 6] & (1UL << (jjmatchedKind & 0x3F))) != 0){
         matchedToken = jjFillToken();
         return matchedToken;
      }
      else
      {
         goto EOFLoop;
      }
   }
   int error_line = input_stream.getEndLine();
   int error_column = input_stream.getEndColumn();
   String error_after = null;
   bool EOFSeen = false;
   try { input_stream.readChar(); input_stream.backup(1); }
   catch (System.IO.IOException e1) {
        #if PCL || CORE || NETSTANDARD || ANDROID || IOS
                    mXparser.doNothing(e1);
		#endif
      EOFSeen = true;
      error_after = curPos <= 1 ? "" : input_stream.GetImage();
      if (curChar == '\n' || curChar == '\r') {
         error_line++;
         error_column = 0;
      }
      else
         error_column++;
   }
   if (!EOFSeen) {
      input_stream.backup(1);
      error_after = curPos <= 1 ? "" : input_stream.GetImage();
   }
   throw new TokenMgrError(EOFSeen, curLexState, error_line, error_column, error_after, curChar, TokenMgrError.LEXICAL_ERROR);
  }
}
}
}
