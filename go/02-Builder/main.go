package main

import "fmt"

func main() {
	var iBuilder = getBuilder("internal")
	iBuilder.setName("Ali")
	iBuilder.setSurname("Kaya")
	iBuilder.setEmail("ali@abc.com")

	var director = newDirector(iBuilder)
	director.build()

	fmt.Println()

	var eBuilder = getBuilder("external")
	eBuilder.setName("Ayşe")
	eBuilder.setSurname("Metin")
	eBuilder.setEmail("ayşe@abc.com")

	director.setBuilder(eBuilder)
	director.build()
}

type IBuilder interface {
	setName(name string)
	setSurname(surname string)
	setEmail(email string)
	build()
}

func getBuilder(eType string) IBuilder {
	if eType == "internal" {
		return &internalEmployeeBuilder{}
	} else if eType == "external" {
		return &externalEmployeeBuilder{}
	}
	return nil
}

type internalEmployeeBuilder struct {
	name    string
	surname string
	email   string
}

func (i *internalEmployeeBuilder) setName(name string) {
	i.name = name
}
func (i *internalEmployeeBuilder) setSurname(surname string) {
	i.surname = surname
}
func (i *internalEmployeeBuilder) setEmail(email string) {
	i.email = email
}
func (i *internalEmployeeBuilder) build() {
	fmt.Printf("Internal Employee is created. Name:%s, Surname:%s, Email:%s", i.name, i.surname, i.email)
}

type externalEmployeeBuilder struct {
	name    string
	surname string
	email   string
}

func (e *externalEmployeeBuilder) setName(name string) {
	e.name = name
}
func (e *externalEmployeeBuilder) setSurname(surname string) {
	e.surname = surname
}
func (e *externalEmployeeBuilder) setEmail(email string) {
	e.email = email
}
func (e *externalEmployeeBuilder) build() {
	fmt.Printf("External Employee is created. Name:%s, Surname:%s, Email:%s", e.name, e.surname, e.email)
}

type director struct {
	builder IBuilder
}

func newDirector(b IBuilder) *director {
	return &director{
		builder: b,
	}
}
func (d *director) setBuilder(b IBuilder) {
	d.builder = b
}
func (d *director) build() {
	d.builder.build()
}
