import { Container, Table } from "react-bootstrap";
import SmjerService from "../../services/SmjerService";
import { useEffect, useState } from "react";
import { NumericFormat } from "react-number-format";


export default function SmjeroviPregled() {

    const [smjerovi, setSmjerovi] = useState();

    async function dohvatiSmjerove() {

        await SmjerService.get()
            .then((odgovor) => {
                setSmjerovi(odgovor)
            })
            .catch((e) => console.error(e));
    }

    useEffect(() => { dohvatiSmjerove() }, []);

    function formatirajDatum(datum){
        if(datum==null){
            return 
        }
    }


    return (
        <Container>
            <Table striped bordered hover responsive>
                <thead>
                    <tr>
                        <th>Naziv</th>
                        <th>Trajanje</th>
                        <th>Cijena</th>
                        <th>Izvodi se od</th>
                        <th>Vaučer</th>
                        <th>Akcija</th>
                    </tr>
                </thead>
                <tbody>
                    {smjerovi && smjerovi.map((smjer, index) => (
                        <tr key={index}>

                            <td>{smjer.naziv}</td>
                            <td className={smjer.trajanje==null ? 'sredina': 'desno'}></td>
                                {smjer.trajanje ==null? 'Nije definirano' : smjer.trajanje}
                            <td className= {smjer.cijena==null ? 'sredina': 'desno'}>
                            
                            
                            {smjer.cijena==null?'Nije definirano'
                            :
                            <NumericFormat
                            value={smjer.cijena}
                            displayType={'text'}
                            thousandSeparator='.'
                            decimalSeparator=','
                            prefix={'€'}
                        decimalScale={2}
                        fixedDecimalScale
                        />
                        
                        
                        }
                            
                            
                            
                            </td>
                            <td>{smjer.izvodiSeOd}</td>
                            <td>{smjer.vaucer}</td>
                            <td>{smjer.sifra}</td>


                        </tr>


                    ))}
                </tbody>
            </Table>
        </Container>
    )
}