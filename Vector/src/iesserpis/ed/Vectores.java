package iesserpis.ed;

import static org.junit.jupiter.api.Assertions.*;


import org.junit.jupiter.api.Test;


class Vectores {

	@Test
	void testIndex0f() {
		int [] v= {17, 12, 15, 9, 14};
		int x= 15;
		int index = VEctor2.index0f(v, x);
		
		assertEquals(2, index);
		assertEquals(2, VEctor2.index0f(v, 17));
	}

}
