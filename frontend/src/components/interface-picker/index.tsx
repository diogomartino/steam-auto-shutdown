import { useMemo } from 'react';
import {
  Button,
  Dropdown,
  DropdownItem,
  DropdownMenu,
  DropdownTrigger,
  Tooltip
} from '@nextui-org/react';
import { setSelectedMac } from '../../actions/app';
import useSelectedMac from '../../hooks/use-selected-mac';
import useInterfaces from '../../hooks/use-interfaces';

const InterfacePicker = () => {
  const selectedMac = useSelectedMac();
  const interfaces = useInterfaces();

  const selectedValue = useMemo(() => {
    const selected = interfaces.find(
      (item) => item.hardwareaddr === selectedMac
    );

    return selected ? `${selected.name}` : '';
  }, [selectedMac, interfaces]);

  return (
    <div className="flex flex-col justify-center items-center gap-2">
      <Tooltip
        showArrow={true}
        color="foreground"
        content="The network interface you want to monitor. It is usually Ethernet or Wi-Fi."
        delay={300}
        closeDelay={0}
      >
        <p className="text-sm">Network Interface</p>
      </Tooltip>

      <Dropdown>
        <DropdownTrigger>
          <Button variant="bordered" className="capitalize">
            {selectedValue || 'Select Network Interface'}
          </Button>
        </DropdownTrigger>
        <DropdownMenu
          aria-label="Single selection example"
          disallowEmptySelection
          selectionMode="single"
          selectedKeys={[selectedMac as string]}
          onSelectionChange={(selection) => {
            const [first] = selection;
            setSelectedMac(first.toString());
          }}
        >
          {interfaces.map((item) => (
            <DropdownItem key={item.hardwareaddr} className="text-foreground">
              {item.name}
            </DropdownItem>
          ))}
        </DropdownMenu>
      </Dropdown>
    </div>
  );
};

export default InterfacePicker;
