import React, { Component } from "react";
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { hideDeleteCategoryModal, deleteCategoryAction } from '../../actions/categoriesActions';
import { Modal, Button } from 'react-bootstrap';

class DeleteCategory extends Component {

  constructor(props) {
    super(props);
    this.state = {
    }
  }

  render() {
    return (
      <>
        <Modal show={this.props.showModal} onHide={this.props.hideDeleteCategoryModal}>
          <Modal.Header closeButton>
            <Modal.Title>Confirmation</Modal.Title>
          </Modal.Header>
          <Modal.Body>Do you really want to delete category '{this.props.deleteCategoryCurrentItem.name}'?</Modal.Body>
          <Modal.Footer>
            <Button variant="secondary" onClick={this.props.hideDeleteCategoryModal}>
              Close
          </Button>
            <Button variant="primary" onClick={() => this.props.deleteCategory(this.props.deleteCategoryCurrentItem.id)}>
              Yes
          </Button>
          </Modal.Footer>
        </Modal>
      </>
    );
  }
}

const mapStateToProps = (state) => ({
  showModal: state.categoriesReducer.showDeleteCategoryModal,
  deleteCategoryCurrentItem: state.categoriesReducer.deleteCategoryCurrentItem
});

const mapDispatchToProps = (dispatch) => bindActionCreators({
  hideDeleteCategoryModal: hideDeleteCategoryModal,
  deleteCategory: deleteCategoryAction
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(DeleteCategory);