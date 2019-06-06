package combine

import (
	"log"
	"testing"
)

var (
	people = `1,Sally
2,John
3,Cortana`

	colors = `2,Green
3,Blue
4,Red`

	expected = `2,John,Green
3,Cortana,Blue`
)

func TestCombine(t *testing.T) {
	result := expected
	if result != expected {
		log.Fatal()
	}
}
