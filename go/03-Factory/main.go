package main

import (
	"design-pattern-examples/go/03-Factory/factory"
	"fmt"
)

func main() {

	car1, _ := factory.GetCar("1")
	car1.PrintCar()
	fmt.Println()
	car2, _ := factory.GetCar("2")
	car2.PrintCar()
}
