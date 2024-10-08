
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import { Navigate, useNavigate } from 'react-router-dom';
import { RoutesNames } from '../constants';


export default function NavbarEdunova(){

    const navigate =useNavigate();

    return(
      
<Navbar expand="lg" className="bg-body-tertiary">
      <Container>
        <Navbar.Brand href="#home">Edunova APP</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="me-auto">
            <Nav.Link onClick={()=>navigate(RoutesNames.HOME)}>Početna</Nav.Link>
            <Nav.Link href="https://mkusen-001-site1.ktempurl.com/swagger/index.html" target='_blank'>swagger</Nav.Link>
            <NavDropdown title="Programi" id="basic-nav-dropdown">
              <NavDropdown.Item  onClick={()=>navigate(RoutesNames.SMJER_PREGLED)}>smjerovi</NavDropdown.Item>
              <NavDropdown.Item href="#action/3.2">
                polaznici
              </NavDropdown.Item>
              <NavDropdown.Item href="#action/3.3">grupe</NavDropdown.Item>
              <NavDropdown.Divider />
              <NavDropdown.Item href="#action/3.4">
                Separated link
              </NavDropdown.Item>
            </NavDropdown>
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>

    );
}