package iesserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

class vectorTest {

	@Test
	void max() {
		//fail("Not yet implemented");
		assertEquals(21, Vector.max((new int [] {14, 21, 12, 9, 7})));
		assertEquals(21, Vector.max((new int [] {14, 1, 12, 9, 21})));
		//caso de vector vacío
		Assertions.assertThrows(IllegalArgumentException.class,
		() -> Vector.max(new int[] {}));
		
	}
	
	@Test
	void selectionSort( ) {
		int[] v1 = {14, 21, 12, 7, 9};
		Vector.selectionSort(v1);
		assertArrayEquals(new int[] {7, 9, 12, 14, 21}, v1);
	}

}
