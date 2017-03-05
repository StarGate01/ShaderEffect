BLD=bld
PROJ=ShaderEffect
INSTALLDIR=/cygdrive/c/Users/$(shell id -u -n)/Documents/Visual Studio 2015/Templates/ItemTemplates/Visual C\#/WPF

.PHONY: build install clean

build:
	$(info Building)
	mkdir -p $(BLD)
	rm -f $(BLD)/$(PROJ).zip
	cd "$(PROJ)" && zip "../$(BLD)/$(PROJ).zip" *

install: build
	$(info Installing)
	mkdir -p "$(INSTALLDIR)"
	cp "$(BLD)/$(PROJ).zip" "$(INSTALLDIR)/$(PROJ).zip"

clean:
	$(info Cleaning)
	rm -rf "$(BLD)"