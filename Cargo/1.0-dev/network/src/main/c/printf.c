/****************************************************************************
 *
 * MODULE:             printf.c
 *
 * COMPONENT:          $RCSfile: printf.c,v $
 *
 * VERSION:            $Name:  $
 *
 * REVISION:           $Revision: 1.2 $
 *
 * DATED:              $Date: 2006/09/05 09:00:37 $
 *
 * STATUS:             $State: Exp $
 *
 * AUTHOR:
 *
 * DESCRIPTION:
 *
 * LAST MODIFIED BY:   $Author: imorr $
 *                     $Modtime: $
 *
 ****************************************************************************
 *
 * This software is owned by Jennic and/or its supplier and is protected
 * under applicable copyright laws. All rights are reserved. We grant You,
 * and any third parties, a license to use this software solely and
 * exclusively on Jennic products. You, and any third parties must reproduce
 * the copyright and warranty notice and any other legend of ownership on each
 * copy or partial copy of the software.
 *
 * THIS SOFTWARE IS PROVIDED "AS IS". JENNIC MAKES NO WARRANTIES, WHETHER
 * EXPRESS, IMPLIED OR STATUTORY, INCLUDING, BUT NOT LIMITED TO, IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE,
 * ACCURACY OR LACK OF NEGLIGENCE. JENNIC SHALL NOT, IN ANY CIRCUMSTANCES,
 * BE LIABLE FOR ANY DAMAGES, INCLUDING, BUT NOT LIMITED TO, SPECIAL,
 * INCIDENTAL OR CONSEQUENTIAL DAMAGES FOR ANY REASON WHATSOEVER.
 *
 * Copyright Jennic Ltd 2005, 2006. All rights reserved
 *
 ****************************************************************************/

/****************************************************************************/
/***        Include files                                                 ***/
/****************************************************************************/
#include "jendefs.h"
#include "serial.h"

/****************************************************************************/
/***        Macro Definitions                                             ***/
/****************************************************************************/

/****************************************************************************/
/***        Type Definitions                                              ***/
/****************************************************************************/

/****************************************************************************/
/***        Local Function Prototypes                                     ***/
/****************************************************************************/

/****************************************************************************/
/***        Exported Variables                                            ***/
/****************************************************************************/

/****************************************************************************/
/***        Local Variables                                               ***/
/****************************************************************************/

/****************************************************************************/
/***        Exported Functions                                            ***/
/****************************************************************************/

/****************************************************************************
 *
 * NAME: vDebug_Init
 *
 * DESCRIPTION:
 *
 *
 * PARAMETERS: Name        RW  Usage
 *
 * RETURNS:
 * void
 *
 ****************************************************************************/

static void printchar(char **str, int c)
{
	if (str)
	{
		**str = c;
		++(*str);
	}
	else
	{
	    vSerial_TxChar(c);
	}
}

#define PAD_RIGHT 1
#define PAD_ZERO 2

static int prints(char **out, const char *string, int width, int pad)
{
	register int pc = 0, padchar = ' ';

	if (width > 0) {
		register int len = 0;
		register const char *ptr;
		for (ptr = string; *ptr; ++ptr) ++len;
		if (len >= width) width = 0;
		else width -= len;
		if (pad & PAD_ZERO) padchar = '0';
	}
	if (!(pad & PAD_RIGHT)) {
		for ( ; width > 0; --width) {
			printchar (out, padchar);
			++pc;
		}
	}
	for ( ; *string ; ++string) {
		printchar (out, *string);
		++pc;
	}
	for ( ; width > 0; --width) {
		printchar (out, padchar);
		++pc;
	}

	return pc;
}

/* the following should be enough for 32 bit int */
#define PRINT_BUF_LEN 12

static int printi(char **out, int i, int b, int sg, int width, int pad, int letbase)
{
	char print_buf[PRINT_BUF_LEN];
	register char *s;
	register int t, neg = 0, pc = 0;
	register unsigned int u = i;

	if (i == 0) {
		print_buf[0] = '0';
		print_buf[1] = '\0';
		return prints (out, print_buf, width, pad);
	}

	if (sg && b == 10 && i < 0) {
		neg = 1;
		u = -i;
	}

	s = print_buf + PRINT_BUF_LEN-1;
	*s = '\0';

	while (u) {
		t = u % b;
		if( t >= 10 )
			t += letbase - '0' - 10;
		*--s = t + '0';
		u /= b;
	}

	if (neg) {
		if( width && (pad & PAD_ZERO) ) {
			printchar (out, '-');
			++pc;
			--width;
		}
		else {
			*--s = '-';
		}
	}

	return pc + prints (out, s, width, pad);
}

static int print(char **out, int *varg)
{
	register int width, pad;
	register int pc = 0;
	register char *format = (char *)(*varg++);
	char scr[2];

	for (; *format != 0; ++format) {
		if (*format == '%') {
			++format;
			width = pad = 0;
			if (*format == '\0') break;
			if (*format == '%') goto out;
			if (*format == '-') {
				++format;
				pad = PAD_RIGHT;
			}
			while (*format == '0') {
				++format;
				pad |= PAD_ZERO;
			}
			for ( ; *format >= '0' && *format <= '9'; ++format) {
				width *= 10;
				width += *format - '0';
			}
			if( *format == 's' ) {
				register char *s = *((char **)varg++);
				pc += prints (out, s?s:"(null)", width, pad);
				continue;
			}
			if( *format == 'd' ) {
				pc += printi (out, *varg++, 10, 1, width, pad, 'a');
				continue;
			}
			if( *format == 'x' ) {
				pc += printi (out, *varg++, 16, 0, width, pad, 'a');
				continue;
			}
			if( *format == 'X' ) {
				pc += printi (out, *varg++, 16, 0, width, pad, 'A');
				continue;
			}
			if( *format == 'u' ) {
				pc += printi (out, *varg++, 10, 0, width, pad, 'a');
				continue;
			}
			if( *format == 'c' ) {

				scr[0] = *varg++;
				scr[1] = '\0';
				pc += prints (out, scr, width, pad);
				continue;
			}
		}
		else {
		out:
			printchar (out, *format);
			++pc;
		}
	}
	if (out) **out = '\0';
	return pc;
}

/* assuming sizeof(void *) == sizeof(int) */
int printf(const char *format, ...)
{
	register int *varg = (int *)(&format);
	return print(0, varg);
}
/*
int sprintf(char *out, const char *format, ...)
{
	register int *varg = (int *)(&format);
	return print(&out, varg);
}
*/

/****************************************************************************/
/***        END OF FILE                                                   ***/
/****************************************************************************/
