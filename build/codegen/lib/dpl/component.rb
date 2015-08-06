require 'codegen/lib/dpl/options'
require 'codegen/lib/dpl/option'
require 'codegen/lib/dpl/array-option'
require 'codegen/lib/dpl/composite-option'

module CodeGen::DPL

    class Component < CodeGen::Component
        include Options

        def csharp_class
            # Spredsheet should be created as Workbook
            return 'Workbook' if name.eql?('Spreadsheet')

            name
        end

        def enum_options
            enums = simple_options.select{ |o| !o.values.nil? }
            composite = composite_options.flat_map { |o| o.options }

            composite.each do |item|
                composite.push(*item.options) if item.composite?

                enums.push(item) if !item.values.nil?
            end

            enums
        end
    end

end
